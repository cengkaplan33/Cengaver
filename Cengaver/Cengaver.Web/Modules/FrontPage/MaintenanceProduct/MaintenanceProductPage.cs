namespace Cenggaver.TvHastanesi.Site.Pages
{
    using Serenity;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
using System.Web.Mvc;

    [RoutePrefix("Arizali-Cihaz-Takip"), Route("{action=index}")]
    public class MaintenanceProductController : Controller
    {
        

        [HttpGet]
        public ActionResult Index(int? TicketId)
        {
            if (TicketId == null)
                return View("~/Modules/FrontPage/MaintenanceProduct/MaintenanceProductIndex.cshtml");


            var model = new Cengaver.TvHastanesi.Models.MaintenanceProductModel();

            using (var connection = SqlConnections.NewByKey("Natro_TvHastanesi"))
            using (var uow = new UnitOfWork(connection))
            {
                model.ServiceTicket = new Cengaver.TvHastanesi.Repositories.ServiceTicketRepository().Retrieve(uow.Connection, new RetrieveRequest() { EntityId = TicketId }).Entity;                
            }

            //model.ServiceTicket .ProductSerialNumber

            //return View("~/Modules/TvHastanesi/ServiceTicket/SonyKrediFatura.cshtml", model);
            //@Url.Action("ViewStockNext", "Inventory", new {firstItem=11});
            return View("~/Modules/FrontPage/MaintenanceProduct/MaintenanceProductIndex.cshtml", model);
        }
    }
}