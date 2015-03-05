
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
        //public Int16 ProductTypeId { get; set; }
        public String ProductMark { get; set; }
        public String ProductModel { get; set; }

        [TextAreaEditor]
        public String ProductDesctiption { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Boolean WarrantyIsActive { get; set; }
        public String WarrantyCode { get; set; }
        public String WarrantySource { get; set; }
        public String WarrantyDefination { get; set; }
               

        [Category("General"),CssClass("eeeeeeeeeeeeeeee")]
        public String InvoiceNumber { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime DeliveryDate { get; set; } 
        public Int32 OperationId { get; set; }    //Hizmet TİPİ
        public Int32 StageId { get; set; }        //SERVİS TİPİ

        [TextAreaEditor]
        public String Description { get; set; }

        [CustomerEditor, Required] // abi burada bir edittor var user editor buraya gelen verilede 
            //ad soyad ve telefon bilgisinin gelmesini istiyorum ve bir editor yazdım 
        public Int32 CustomerId { get; set; }

        [LookupEditor(typeof(Administration.Entities.UserRow)), Required]
        public Int32 RecordedByUserId { get; set; }

        [LookupEditor(typeof(Administration.Entities.UserRow))]
        public Int32 DeliveredByUserId { get; set; } 


        [Category("Note")]
        [TextAreaEditor]
        public String MalFunction { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        [TextAreaEditor]
        public String TechnicianNote { get; set; }
        public String StateCode { get; set; }
        public String SymptomCode { get; set; }
        public String MalfunctionCode { get; set; }
        public String SectionCode { get; set; }
        

        [Category("Cost")]
        public Decimal RepairCost { get; set; }
        public Decimal LaborCost { get; set; }
        public Decimal PieceCost { get; set; }
        public String TotalCost { get; set; }
        public Int16 PaymentTypeId { get; set; }
    }
}