
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("TvHastanesi.ServiceTicket")]
    [BasedOnRow(typeof(Entities.ServiceTicketRow))]
    public class ServiceTicketForm
    {
        [Category("ProductInfo")]
        public String ProductSerialNumber { get; set; }
        public Int16 ProductTypeId { get; set; }
        public String ProductMark { get; set; }
        public String ProductModel { get; set; }
        public String ProductDesctiption { get; set; }

        [Category("General")]
        public String InvoiceNumber { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Int32 OperationId { get; set; }    //Hizmet TİPİ
        public Int32 StageId { get; set; }        //SERVİS TİPİ
        public String Description { get; set; }
        public Int32 CustomerId { get; set; }
        //public String RecordDate { get; set; }        //böyle bir alan yok

        [Category("Note")]
        public String MalFunction { get; set; }
        public String TechnicianNote { get; set; }

        [Category("Cost")]
        public Decimal RepairCost { get; set; }
        public Decimal LaborCost { get; set; }
        public Decimal PieceCost { get; set; }
        public String TotalCost { get; set; }
        public Int16 PaymentTypeId { get; set; }
    }
}