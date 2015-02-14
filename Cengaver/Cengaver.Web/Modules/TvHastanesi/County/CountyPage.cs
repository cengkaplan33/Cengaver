namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/County"), Route("{action=index}")]
    public class CountyController : Controller
    {
        [PageAuthorize(PermissionKeys.Admin)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/County/CountyIndex.cshtml");
        }
    }
}