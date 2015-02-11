namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Arizali-Cihaz-Takip"), Route("{action=index}")]
    public class MaintenanceProductController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Modules/FrontPage/MaintenanceProduct/MaintenanceProductIndex.cshtml");
        }
    }
}