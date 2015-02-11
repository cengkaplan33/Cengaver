namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Bilgisayar-Tablet"), Route("{action=index}")]
    public class ComputerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Modules/FrontPage/Computer/ComputerIndex.cshtml");
        }
    }
}