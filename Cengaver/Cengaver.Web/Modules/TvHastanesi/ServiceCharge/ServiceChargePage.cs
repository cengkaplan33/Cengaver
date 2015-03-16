namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/ServiceCharge"), Route("{action=index}")]
    public class ServiceChargeController : Controller
    {
        [PageAuthorize(PermissionKeys.ServiceRegistry)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/ServiceCharge/ServiceChargeIndex.cshtml");
        }
    }
}