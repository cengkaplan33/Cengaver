
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("UnitId"), NameProperty("Unit"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.Unit"), LocalTextPrefix("TvHastanesi.Unit"), Service("TvHastanesi/Unit")]
    public class UnitDialog : EntityDialog<UnitRow>
    {
    }
}