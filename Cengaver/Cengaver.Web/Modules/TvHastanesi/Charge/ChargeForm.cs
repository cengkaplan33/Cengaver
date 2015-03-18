
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Cengaver.TvHastanesi.Enums;

    [FormScript("TvHastanesi.Charge")]
    [BasedOnRow(typeof(Entities.ChargeRow))]
    public class ChargeForm
    {
        public String Charge { get; set; }
        public String Code { get; set; }
        public Int16 TaxRate { get; set; }
        public Boolean TaxIncluded { get; set; }
        public Decimal Price { get; set; }
        public ChargeType Type { get; set; }

        //public Int32 InsertUserId { get; set; }
        //public DateTime InsertDate { get; set; }
        //public Int16 IsActive { get; set; }
        //public Int32 UpdateUserId { get; set; }
        //public DateTime UpdateDate { get; set; }
    }
}