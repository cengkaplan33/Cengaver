
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.County")]
    [BasedOnRow(typeof(Entities.CountyRow))]
    public class CountyColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CountyId { get; set; }

        [EditLink(ItemType = "TvHastanesi.City", IdField = "CityId"), Width(150)]
        public Int32 CityId { get; set; }
        [EditLink]
        public String County { get; set; }
    }
}


