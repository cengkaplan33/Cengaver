
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("ServiceTicketId"), NameProperty("ProductSerialNumber"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.ServiceTickets"), LocalTextPrefix("TvHastanesi.ServiceTickets"), Service("TvHastanesi/ServiceTickets")]
    public class ServiceTicketsDialog : EntityDialog<ServiceTicketsRow>
    {
    }
}