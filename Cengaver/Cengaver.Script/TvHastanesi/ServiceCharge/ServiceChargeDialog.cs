
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("ServiceChargeId"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.ServiceCharge"), LocalTextPrefix("TvHastanesi.ServiceCharge"), Service("TvHastanesi/ServiceCharge")]
    public class ServiceChargeDialog : EntityDialog<ServiceChargeRow>
    {
    }
}