
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.ServiceCharge"), IdProperty("ServiceChargeId"), IsActiveProperty("IsActive")]
    [DialogType(typeof(ServiceChargeDialog)), LocalTextPrefix("TvHastanesi.ServiceCharge"), Service("TvHastanesi/ServiceCharge")]
    public class ServiceChargeGrid : EntityGrid<ServiceChargeRow>
    {
        public ServiceChargeGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}