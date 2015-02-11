
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.Menu"), IdProperty("MenuId"), NameProperty("Menu"), IsActiveProperty("IsActive")]
    [DialogType(typeof(MenuDialog)), LocalTextPrefix("TvHastanesi.Menu"), Service("TvHastanesi/Menu")]
    public class MenuGrid : EntityGrid<MenuRow>
    {
        public MenuGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}