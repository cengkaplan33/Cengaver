namespace Cengaver.Common.Pages
{
    using Serenity;
    using Serenity.Reporting;
    using Serenity.Web;
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    [RoutePrefix("Report"), Route("{action=index}")]
    public class ReportController : Controller
    {
        // bunu konfigürasyon vs. biryerden almalıyız
        private const string DefaultCategoryOrder = "Personel/Akademik; Personel/İdari; Personel/Diğer";

        [Authorize, PageAuthorize("Administration")]
        public ActionResult Index(string id)
        {
            id = "Cengaver";
            var reports = ReportRegistry.GetAvailableReportsInCategory(null);
            var model = CreatePageModel(reports, id);

            return View("~/Modules/Common/Reporting/ReportIndex.cshtml", model);
        }

        protected internal ReportPageModel CreatePageModel(IEnumerable<ReportRegistry.Report> reports, string rootPath,
            string categoryOrder = DefaultCategoryOrder)
        {
            if (reports == null)
                throw new ArgumentNullException("reports");

            rootPath = rootPath ?? "";
            categoryOrder = categoryOrder ?? "";

            var model = new ReportPageModel();

            var categoryByKey = new Dictionary<string, ReportPageModel.Category>(StringComparer.CurrentCultureIgnoreCase);

            foreach (var report in reports)
            {
                ReportPageModel.Category category;
                if (categoryByKey.TryGetValue(report.Category.Key ?? "", out category))
                {
                    category.Reports.Add(report);
                    continue;
                }

                var parts = (report.Category.Key.TrimToNull() ?? "Diğer").Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                string current = "";
                category = null;
                foreach (var part in parts)
                {
                    string prior = current;

                    if (current.Length > 0)
                        current += "/";

                    current += part;

                    if (current.Length <= rootPath.Length)
                        continue;

                    if (!categoryByKey.TryGetValue(current ?? "", out category))
                    {
                        category = new ReportPageModel.Category();
                        category.Key = current;
                        category.Title = ReportRegistry.GetReportCategoryTitle(current);
                        categoryByKey[current] = category;

                        if (!categoryByKey.ContainsKey(prior))
                            model.Root.SubCategories.Add(category);
                        else
                        {
                            var x = categoryByKey[prior];
                            x.SubCategories.Add(category);
                        }
                    }
                }

                if (category == null)
                    model.Root.Reports.Add(report);
                else
                    category.Reports.Add(report);
            }

            var order = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            var i = 0;
            foreach (var x in categoryOrder.Split(new char[] { ';' }))
            {
                var xt = x.TrimToNull();
                if (xt != null)
                    order[xt] = i++;
            }

            Comparison<ReportPageModel.Category> sort = (x, y) =>
            {
                var c = 0;

                if (x.Key != y.Key)
                {
                    var c1 = order.ContainsKey(x.Key) ? (Int32?)order[x.Key] : null;
                    var c2 = order.ContainsKey(y.Key) ? (Int32?)order[y.Key] : null;
                    if (c1 != null && c2 != null)
                        c = c1.Value - c2.Value;
                    else if (c1 != null)
                        c = -1;
                    else if (c2 != null)
                        c = 1;
                }

                if (c == 0)
                    c = String.Compare(x.Title, y.Title, StringComparison.CurrentCultureIgnoreCase);

                return c;
            };

            foreach (var category in categoryByKey.Values)
                if (category.SubCategories != null)
                    category.SubCategories.Sort(sort);

            model.Root.SubCategories.Sort(sort);
            return model;
        }
    }


    public class ReportPageModel
    {
        public Category Root { get; set; }

        public ReportPageModel()
        {
            Root = new Category();
        }

        public class Category
        {
            public string Key { get; set; }
            public string Title { get; set; }
            public List<Category> SubCategories { get; private set; }
            public List<ReportRegistry.Report> Reports { get; private set; }

            public Category()
            {
                SubCategories = new List<Category>();
                Reports = new List<ReportRegistry.Report>();
            }
        }
    }
}