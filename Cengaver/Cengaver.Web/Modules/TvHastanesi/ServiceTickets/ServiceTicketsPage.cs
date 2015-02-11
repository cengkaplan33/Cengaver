namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/ServiceTickets"), Route("{action=index}")]
    public class ServiceTicketsController : Controller
    {
        [PageAuthorize(PermissionKeys.General)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/ServiceTickets/ServiceTicketsIndex.cshtml");
        }
    }
}