
namespace Cengaver.Common.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Net.Mime;
    using System.Web.Mvc;
    using Cengaver.Common.Repositories;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.Reporting;
    using Serenity.Services;

    [RoutePrefix("Services/Report"), Route("{action=index}")]
    public class ReportController : Controller
    {
        private const string ConnectionKey = "Default";

        private static Dictionary<ReportExportType, string> ExportExtensions = new Dictionary<ReportExportType, string>
        {
            { ReportExportType.Doc, "docx" },
            { ReportExportType.Docx, "docx" },
            { ReportExportType.Pdf, "pdf" },
            { ReportExportType.Xls, "xls" },
            { ReportExportType.Xlsx, "xlsx" }
        };


        [Authorize, AcceptVerbs("GET", "POST"), JsonFilter]
        public ActionResult Retrieve(ReportRetrieveRequest request)
        {
            return this.UseConnection(ConnectionKey, (cnn) => new ReportRepository().Retrieve(cnn, request));
        }

        [Authorize, AcceptVerbs("GET", "POST"), JsonFilter]
        public ActionResult Execute(ReportExecuteRequest request)
        {
            request.CheckNotNull();

            if (request.ReportKey.IsEmptyOrNull())
                throw new ArgumentNullException("reportKey");

            if (request.DesignId.IsEmptyOrNull())
                throw new ArgumentNullException("designId");

            var reportInfo = ReportRegistry.GetReport(request.ReportKey);
            if (reportInfo == null)
                throw new ArgumentOutOfRangeException("reportKey");

            var report = JsonConvert.DeserializeObject(request.Parameters.ToJson(), reportInfo.Type, JsonSettings.Tolerant);

            var exportType = request.ExportType ?? ReportExportType.Pdf;
            byte[] rendered = new ReportRepository().RenderReport((IReport)report,
                request.ReportKey, request.DesignId, exportType);

            string fileDownloadName;
            var customFileName = report as ICustomFileName;
            if (customFileName != null)
                fileDownloadName = customFileName.GetFileName();
            else
                fileDownloadName = (reportInfo.Title ?? reportInfo.Key) + "_" +
                    DateTime.Now.ToString("yyyyMMdd_HHss");
            
            fileDownloadName += "." + ExportExtensions[exportType];

            if (request.ExportType == null)
            {
                var cd = new ContentDisposition
                {
                    Inline = true,
                    FileName = fileDownloadName
                };

                Response.AddHeader("Content-Disposition", cd.ToString());
                return File(rendered, "application/pdf");
            }
            else
            {
                return new FileContentResult(rendered, "application/octet-stream")
                {
                    FileDownloadName = fileDownloadName
                };
            }
        }
    }
}
