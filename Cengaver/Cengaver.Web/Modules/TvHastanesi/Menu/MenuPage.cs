namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/Menu"), Route("{action=index}")]
    public class MenuController : Controller
    {
        [PageAuthorize(PermissionKeys.Admin)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/Menu/MenuIndex.cshtml");
        }
    }
}