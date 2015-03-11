namespace Cengaver.Common.Repositories
{
    //using Microsoft.Reporting.WebForms; 
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.Reporting;
    using Serenity.Services;
    using Serenity.Web;
    using Serenity.Web.PropertyEditor;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.IO;
    using System.Web.Hosting;

    public class ReportRepository
    {
        const string ReportUploadPath = "report";

        public ReportRetrieveResponse Retrieve(IDbConnection connection, ReportRetrieveRequest request)
        {
            request.CheckNotNull();

            if (request.ReportKey.IsTrimmedEmpty())
                throw new ArgumentNullException("reportKey");

            var report = ReportRegistry.GetReport(request.ReportKey);

            if (report == null)
                throw new ArgumentOutOfRangeException("reportKey");

            var response = new ReportRetrieveResponse();

            response.Properties = Serenity.PropertyGrid.PropertyItemHelper.GetPropertyItemsFor(report.Type);
            response.Designs = GetReportDesigns(connection, request.ReportKey);
            response.ReportKey = report.Key;
            response.Title = report.Title;
            var reportInstance = Activator.CreateInstance(report.Type);
            response.InitialSettings = reportInstance;
            response.IsDataOnlyReport = reportInstance is IDataOnlyReport;

            return response;
        }

        public List<ReportDesignItem> GetReportDesigns(IDbConnection connection, string reportKey)
        {
            if (reportKey.IsEmptyOrNull())
                throw new ArgumentNullException("reportKey");

            return new List<ReportDesignItem>
            {
                new ReportDesignItem { DesignId = "Default", ReportKey = reportKey }
            };
        }

        private static string reportsRootPath;

        public string GetReportDesignPath(string reportKey, string designId)
        {
            if (reportKey.IsEmptyOrNull())
                throw new ArgumentNullException("reportKey");

            UploadHelper.CheckFileNameSecurity(designId);

            if (reportsRootPath == null)
            {
                var configuredPath = ConfigurationManager.AppSettings["ReportsRootPath"].TrimToNull() ?? "~/Reports";
                if (configuredPath != null && configuredPath.StartsWith("~/"))
                    configuredPath = HostingEnvironment.MapPath(configuredPath);
                reportsRootPath = configuredPath;
            }

            var baseFileName = Path.Combine(reportsRootPath, reportKey + "." + designId);
            var fileName = baseFileName + ".rdl";

            if (!File.Exists(fileName) &&
                File.Exists(baseFileName + ".trdx"))
            {
                return baseFileName + ".trdx";
            }

            return fileName;
        }

        public Stream OpenReportDesign(string reportKey, string designId, out string extension)
        {
            if (reportKey.IsEmptyOrNull())
                throw new ArgumentNullException("reportKey");

            var fileName = GetReportDesignPath(reportKey, designId);
            extension = Path.GetExtension(fileName);
            return new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
        }

/*
        private IEnumerable<Telerik.Reporting.ReportItemBase> TelerikReportEnumerateChildren(Telerik.Reporting.ReportItemBase item)
        {
            foreach (var child in item.Items)
            {
                yield return child;
                foreach (var sub in TelerikReportEnumerateChildren(child))
                    yield return sub;
            }
        }

        private Telerik.Reporting.Report TelerikReportLoad(Stream input)
        {
            var settings = new System.Xml.XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (var xmlReader = System.Xml.XmlReader.Create(input, settings))
            {
                var xmlSerializer = new Telerik.Reporting.XmlSerialization.ReportXmlSerializer();
                return (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }
        }

        private void TelerikReportReplaceDataSources(Telerik.Reporting.Report report, IDictionary<string, object> dataSources)
        {
            foreach (var pair in dataSources)
                dataSources[pair.Key] = new Telerik.Reporting.ObjectDataSource(pair.Value, null);

            var original = report.DataSource as Telerik.Reporting.DataSource;
            object replace;
            if (original != null && original.Name != null && dataSources.TryGetValue(original.Name, out replace))
               report.DataSource = replace;

            foreach (var item in TelerikReportEnumerateChildren(report))
            {
                var dataItem = item as Telerik.Reporting.DataItem;
                if (dataItem == null)
                    continue;

                original = dataItem.DataSource as Telerik.Reporting.DataSource;
                if (original != null && original.Name != null && dataSources.TryGetValue(original.Name, out replace))
                    dataItem.DataSource = replace;
            }
        }
*/
        private byte[] RenderDataOnlyReport(IDataOnlyReport report, IDictionary<string, object> dataSources)
        {
            var columns = report.GetColumnList();
            
            var rows = new List<object>();
            var data = dataSources["Main"] as IEnumerable;
            if (data != null)
                foreach (var obj in data)
                    rows.Add(obj);

            var package = GenerateExcelFileHelper.Generate(columns, rows);
            
            using (var ms = new MemoryStream())
            {
                package.SaveAs(ms);
                return ms.ToArray();
            }
        }

        public byte[] RenderDataOnlyReport(IDataOnlyReport report)
        {
            return RenderDataOnlyReport(report, GetDataSources(report));
        }

        private IDictionary<string, object> GetDataSources(IReport report)
        {
            var dataSources = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            dataSources.Add("Main", report.GetData());

            var iadditional = report as IReportWithAdditionalData;
            if (iadditional != null)
            {
                var additional = iadditional.GetAdditionalData();
                if (additional != null && additional.Count > 0)
                {
                    foreach (var ds in additional)
                    {
                        dataSources.Add(ds.Key, ds.Value);
                    }
                }
            }

            return dataSources;
        }

        public byte[] RenderReport(IReport report, string reportKey, string designId, ReportExportType exportType)
        {
            if (reportKey.IsEmptyOrNull())
                throw new ArgumentNullException("reportKey");

            if (designId.IsEmptyOrNull())
                throw new ArgumentNullException("designId");

            var dataSources = GetDataSources(report);

            if (report is IDataOnlyReport)
            {
                if (exportType != ReportExportType.Xlsx)
                    throw new ArgumentOutOfRangeException("exportType");

                return RenderDataOnlyReport((IDataOnlyReport)report, dataSources);
            }

            string extension;
            using (var stream = new ReportRepository().OpenReportDesign(reportKey, designId, out extension))
            {
                /*
                if ((extension ?? "").ToLowerInvariant() == ".trdx")
                {
                    var trpReport = TelerikReportLoad(stream);
                    TelerikReportReplaceDataSources(trpReport, dataSources);

                    var trpSource = new Telerik.Reporting.InstanceReportSource { ReportDocument = trpReport };
                    var trpProcessor = new Telerik.Reporting.Processing.ReportProcessor();

                    var trpResult = trpProcessor.RenderReport(ExportFormats[exportType], trpSource, null);

                    return trpResult.DocumentBytes;
                }
                else
                */
                {
                    //LocalReport ssrs = new LocalReport();
                    //ssrs.LoadReportDefinition(stream);

                    //ssrs.DataSources.Clear();
                    //foreach (var pair in dataSources)
                    //    ssrs.DataSources.Add(new ReportDataSource(pair.Key, pair.Value));

                    //return ssrs.Render(ExportFormats[exportType]);
                    throw new NotImplementedException();
                }
            }
        }

        private static Dictionary<ReportExportType, string> ExportFormats = new Dictionary<ReportExportType, string>
        {
            { ReportExportType.Doc, "WORD" },
            { ReportExportType.Docx, "WORDOPENXML" },
            { ReportExportType.Pdf, "PDF" },
            { ReportExportType.Xls, "EXCEL" },
            { ReportExportType.Xlsx, "EXCELOPENXML" }
        };
    }
}