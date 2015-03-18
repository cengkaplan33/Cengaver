
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.Charge"), IdProperty("ChargeId"), NameProperty("Charge"), IsActiveProperty("IsActive")]
    [DialogType(typeof(ChargeDialog)), LocalTextPrefix("TvHastanesi.Charge"), Service("TvHastanesi/Charge")]
    public class ChargeGrid : EntityGrid<ChargeRow>
    {
        public ChargeGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}