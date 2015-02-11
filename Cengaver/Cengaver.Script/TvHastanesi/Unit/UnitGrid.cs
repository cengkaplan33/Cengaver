
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.Unit"), IdProperty("UnitId"), NameProperty("Unit"), IsActiveProperty("IsActive")]
    [DialogType(typeof(UnitDialog)), LocalTextPrefix("TvHastanesi.Unit"), Service("TvHastanesi/Unit")]
    public class UnitGrid : EntityGrid<UnitRow>
    {
        public UnitGrid(jQueryObject container)
            : base(container)
        {
        }
    }

    // Please remove this partial class or the first line below, after you run ScriptContexts.tt
    [Imported, Serializable, PreserveMemberCase] 
    public partial class UnitRow
    {
    }
}