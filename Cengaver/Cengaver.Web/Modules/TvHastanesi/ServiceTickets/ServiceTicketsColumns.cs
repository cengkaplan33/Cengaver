
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.ServiceTickets")]
    [BasedOnRow(typeof(Entities.ServiceTicketsRow))]
    public class ServiceTicketsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ServiceTicketId { get; set; }
        public DateTime ReceiveDate { get; set; }
        [EditLink]
        public String ProductSerialNumber { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int16 ProductTypeId { get; set; }
        public Boolean IsActive { get; set; }
        public String ProductMark { get; set; }
        public String ProductModel { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public String ProductDesctiption { get; set; }
        public String MalFunction { get; set; }
        public String TechnicianNote { get; set; }
        public Decimal RepairCost { get; set; }
        public Decimal LaborCost { get; set; }
        public Decimal PieceCost { get; set; }
        public String TotalCost { get; set; }
        public Int16 PaymentTypeId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Int32 OperationId { get; set; }
        public Int32 StageId { get; set; }
        public String Description { get; set; }

        [EditLink(ItemType = "TvHastanesi.Customer", IdField = "CustomerId"), Width(150)]
        public Int32 CustomerId { get; set; }
        public String InvoiceNumber { get; set; }
        public String RecordDate { get; set; }
    }
}