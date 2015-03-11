namespace Marmara.Common.Endpoints
{
    using Serenity.Reporting;
    using Serenity.Services;
    using System.Web.Mvc;
    using MyRepository = Repositories.ReportDesignRepository;

    [RoutePrefix("Services/ReportDesign"), Route("{action=index}")]
    public class ReportDesignController : Controller
    {
        [AcceptVerbs("GET", "POST"), JsonFilter]
        public ActionResult List(ReportDesignListRequest request)
        {
            return this.UseConnection("Personel", cnn => new MyRepository().List(cnn, request));
        }
    }
}