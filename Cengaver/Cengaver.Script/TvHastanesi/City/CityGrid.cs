
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.City"), IdProperty("CityId"), NameProperty("City")]
    [DialogType(typeof(CityDialog)), LocalTextPrefix("TvHastanesi.City"), Service("TvHastanesi/City")]
    public class CityGrid : EntityGrid<CityRow>
    {
        public CityGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}