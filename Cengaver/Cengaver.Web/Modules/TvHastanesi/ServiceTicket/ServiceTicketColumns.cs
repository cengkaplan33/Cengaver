
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.ServiceTicket")]
    [BasedOnRow(typeof(Entities.ServiceTicketRow))]
    public class ServiceTicketColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ServiceTicketId { get; set; }
        public DateTime ReceiveDate { get; set; }
        [EditLink]
        public String ProductSerialNumber { get; set; }
        public Int16 ProductTypeId { get; set; }
        public Boolean IsActive { get; set; }
        public String ProductMark { get; set; }
        public String ProductModel { get; set; }
        public String ProductDesctiption { get; set; }
        public String MalFunction { get; set; }
        public Int32 OperationId { get; set; }
        public Int32 StageId { get; set; }
        public String Description { get; set; }

    }
}