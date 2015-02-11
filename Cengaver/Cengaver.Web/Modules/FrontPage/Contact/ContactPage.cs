namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("iletisim"), Route("{action=index}")]
    public class ContactController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Modules/FrontPage/Contact/ContactIndex.cshtml");
        }
    }
}