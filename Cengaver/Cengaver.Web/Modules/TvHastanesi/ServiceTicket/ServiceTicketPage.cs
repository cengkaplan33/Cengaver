

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "TvHastanesi/ServiceTicket", typeof(Cengaver.TvHastanesi.Pages.ServiceTicketController))]

namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/ServiceTicket"), Route("{action=index}")]
    public class ServiceTicketController : Controller
    {
        [PageAuthorize("rrrrr")]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/ServiceTicket/ServiceTicketIndex.cshtml");
        }
    }
}