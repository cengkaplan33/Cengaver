namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Telefon"), Route("{action=index}")]
    public class PhoneController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Modules/FrontPage/Phone/PhoneIndex.cshtml");

        }
    }
}