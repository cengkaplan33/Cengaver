
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("TvHastanesi.County")]
    [BasedOnRow(typeof(Entities.CountyRow))]
    public class CountyForm
    {
        [LookupEditor(typeof(Entities.CityRow))]
        public Int32 CityId { get; set; }
        public String County { get; set; }
    }
}