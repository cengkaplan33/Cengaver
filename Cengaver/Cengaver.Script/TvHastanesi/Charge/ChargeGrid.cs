
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

    // Please remove this partial class or the first line below, after you run ScriptContexts.tt
    [Imported, Serializable, PreserveMemberCase] 
    public partial class ChargeRow
    {
    }
}