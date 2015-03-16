namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/Charge"), Route("{action=index}")]
    public class ChargeController : Controller
    {
        [PageAuthorize(PermissionKeys.ServiceRegistry)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/Charge/ChargeIndex.cshtml");
        }
    }
}