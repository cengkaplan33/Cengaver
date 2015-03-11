
namespace Cengaver.TvHastanesi.Endpoints
{
    using Cengaver.TvHastanesi.Enums;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.ServiceTicketRepository;
    using MyRow = Entities.ServiceTicketRow;

    [RoutePrefix("TvHastanesi/ServiceTicketForm"), Route("{action=index}"), Authorize]
    public partial class ServiceTicketFormController : Controller
    {
        public ActionResult Index(int serviceTicketId,ServiceTicketFormType FormType)
        {
            var model = new Models.ServiceTicketFormModel();

            using (var connection = SqlConnections.NewByKey("Natro_TvHastanesi"))
            using (var uow = new UnitOfWork(connection))
            {
                model.ServiceTicket = new MyRepository().Retrieve(uow.Connection, new RetrieveRequest() { EntityId = serviceTicketId }).Entity;
                model.Customer = new Endpoints.CustomerController().Retrieve(uow.Connection, new RetrieveRequest() { EntityId = model.ServiceTicket.CustomerId }).Entity;
            }

            if (FormType == ServiceTicketFormType.RegistrationTechnician)
                return View("~/Modules/TvHastanesi/ServiceTicket/ServiceRegistrationTechnicianForm.cshtml", model);
            else if (FormType == ServiceTicketFormType.RegistationUser)    
                return View("~/Modules/TvHastanesi/ServiceTicket/ServiceRegistrationUserForm.cshtml", model);
            else if (FormType == ServiceTicketFormType.Sony)
                return View("~/Modules/TvHastanesi/ServiceTicket/ServiceSonyForm.cshtml", model);

            return Content("Rapor şablonu bulunamadı.");
        }
    }
}
