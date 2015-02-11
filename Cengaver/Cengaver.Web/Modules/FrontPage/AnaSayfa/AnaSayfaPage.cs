namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("AnaSayfa"), Route("{action=index}")]
    public class AnaSayfaController : Controller
    {
        [HttpGet, Route("~/")]
        public ActionResult Index()
        { 
            return View("~/Modules/FrontPage/AnaSayfa/AnaSayfaIndex.cshtml");
        }


    }
}