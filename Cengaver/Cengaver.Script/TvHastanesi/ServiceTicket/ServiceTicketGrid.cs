
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

    // Please remove this partial class or the first line below, after you run ScriptContexts.tt
    [Imported, Serializable, PreserveMemberCase] 
    public partial class ServiceTicketRow
    {
    }
}