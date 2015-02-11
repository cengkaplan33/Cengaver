
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.ServiceTickets"), IdProperty("ServiceTicketId"), NameProperty("ProductSerialNumber"), IsActiveProperty("IsActive")]
    [DialogType(typeof(ServiceTicketsDialog)), LocalTextPrefix("TvHastanesi.ServiceTickets"), Service("TvHastanesi/ServiceTickets")]
    public class ServiceTicketsGrid : EntityGrid<ServiceTicketsRow>
    {
        public ServiceTicketsGrid(jQueryObject container)
            : base(container)
        {
        }
    }

    // Please remove this partial class or the first line below, after you run ScriptContexts.tt
    [Imported, Serializable, PreserveMemberCase] 
    public partial class ServiceTicketsRow
    {
    }
}