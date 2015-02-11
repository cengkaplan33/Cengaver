
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("ServiceTicketId"), NameProperty("ProductSerialNumber"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.ServiceTicket"), LocalTextPrefix("TvHastanesi.ServiceTicket"), Service("TvHastanesi/ServiceTicket")]
    public class ServiceTicketDialog : EntityDialog<ServiceTicketRow>
    {
    }
}