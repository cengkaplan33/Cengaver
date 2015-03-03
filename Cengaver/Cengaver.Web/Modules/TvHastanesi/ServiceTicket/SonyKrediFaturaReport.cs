
namespace Cengaver.TvHastanesi.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.ServiceTicketRepository;
    using MyRow = Entities.ServiceTicketRow;

    [RoutePrefix("TvHastanesi/SonyKrediFaturaReport"), Route("{action=index}"),Authorize]
    public partial class SonyKrediFaturaReportController : Controller
    {
        public ActionResult Index(int serviceTicketId)
        {
            var model = new Models.SonyKrediFaturaModel();

            using (var connection = SqlConnections.NewByKey("Natro_TvHastanesi"))
            using (var uow = new UnitOfWork(connection))
            {
                model.ServiceTicket = new MyRepository().Retrieve(uow.Connection, new RetrieveRequest() { EntityId = serviceTicketId }).Entity;
                model.Customer = new Endpoints.CustomerController().Retrieve(uow.Connection, new RetrieveRequest() { EntityId = model.ServiceTicket.CustomerId }).Entity;
            }

            return View("~/Modules/TvHastanesi/ServiceTicket/SonyKrediFatura.cshtml", model);
        }
    }
}

namespace Cengaver.TvHastanesi.Models
{
    public class SonyKrediFaturaModel
    {
        public Entities.ServiceTicketRow ServiceTicket { get; set; }
        public Entities.CustomerRow Customer { get; set; }
    }

    public class MaintenanceProductModel
    {
        public Entities.ServiceTicketRow ServiceTicket { get; set; }
    }
}

