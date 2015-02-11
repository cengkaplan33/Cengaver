namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ev-elektronigi"), Route("{action=index}")]
    public class HomeElectronicsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Modules/FrontPage/HomeElectronics/HomeElectronicsIndex.cshtml");
        }
    }
}