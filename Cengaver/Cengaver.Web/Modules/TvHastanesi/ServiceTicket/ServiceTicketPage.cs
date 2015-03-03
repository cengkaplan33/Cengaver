namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/ServiceTicket"), Route("{action=index}")]
    public class ServiceTicketController : Controller
    {
        [PageAuthorize(PermissionKeys.ServiceRegistry)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/ServiceTicket/ServiceTicketIndex.cshtml");
        }
    }
}