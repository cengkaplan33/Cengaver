
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.ServiceCharge")]
    [BasedOnRow(typeof(Entities.ServiceChargeRow))]
    public class ServiceChargeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ServiceChargeId { get; set; }
        public Int32 ChargeId { get; set; }
        public Int32 ServiceTicketId { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int16 IsActive { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int16 TaxRate { get; set; }
        public Boolean TaxIncluded { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal TotalTaxAmount { get; set; }
        public Decimal TotalAmount { get; set; }
        public Int16 Type { get; set; }
    }
}