namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/City"), Route("{action=index}")]
    public class CityController : Controller
    {
        [PageAuthorize(PermissionKeys.Admin)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/City/CityIndex.cshtml");
        }
    }
}