
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("CityId"), NameProperty("City")]
    [FormKey("TvHastanesi.City"), LocalTextPrefix("TvHastanesi.City"), Service("TvHastanesi/City")]
    public class CityDialog : EntityDialog<CityRow>
    {
    }
}