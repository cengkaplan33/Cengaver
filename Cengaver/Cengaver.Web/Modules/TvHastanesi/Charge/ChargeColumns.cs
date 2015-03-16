
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.Charge")]
    [BasedOnRow(typeof(Entities.ChargeRow))]
    public class ChargeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ChargeId { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int16 IsActive { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        [EditLink]
        public String Charge { get; set; }
        public String Code { get; set; }
        public Int16 TaxRate { get; set; }
        public Boolean TaxIncluded { get; set; }
        public Decimal Price { get; set; }
        public Int16 Type { get; set; }
    }
}