namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Hakkimizda"), Route("{action=index}")]
    public class AboutUsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Modules/FrontPage/AboutUs/AboutUsIndex.cshtml");

        }
    }
}