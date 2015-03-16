
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("ChargeId"), NameProperty("Charge"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.Charge"), LocalTextPrefix("TvHastanesi.Charge"), Service("TvHastanesi/Charge")]
    public class ChargeDialog : EntityDialog<ChargeRow>
    {
    }
}