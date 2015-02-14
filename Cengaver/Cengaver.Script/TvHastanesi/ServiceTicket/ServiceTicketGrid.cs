
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.ServiceTicket"), IdProperty("ServiceTicketId"), NameProperty("ProductSerialNumber"), IsActiveProperty("IsActive")]
    [DialogType(typeof(ServiceTicketDialog)), LocalTextPrefix("TvHastanesi.ServiceTicket"), Service("TvHastanesi/ServiceTicket")]
    public class ServiceTicketGrid : EntityGrid<ServiceTicketRow>
    {
        public ServiceTicketGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}