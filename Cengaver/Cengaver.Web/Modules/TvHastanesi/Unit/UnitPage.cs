namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/Unit"), Route("{action=index}")]
    public class UnitController : Controller
    {
        [PageAuthorize(PermissionKeys.Admin)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/Unit/UnitIndex.cshtml");
        }
    }
}