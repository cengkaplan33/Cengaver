﻿
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.County"), IdProperty("CountyId"), NameProperty("County")]
    [DialogType(typeof(CountyDialog)), LocalTextPrefix("TvHastanesi.County"), Service("TvHastanesi/County")]
    public class CountyGrid : EntityGrid<CountyRow>
    {
        public CountyGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}