
namespace Cengaver.TvHastanesi.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__ServiceTickets"), InstanceName("TvH__ServiceTickets"), TwoLevelCached]
    [DeletePermission(PermissionKeys.ServiceRegistry)]
    [ModifyPermission(PermissionKeys.ServiceRegistry)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class ServiceTicketRow : Cengaver.Administration.Entities.LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Product Serial Number"), Size(10), NotNull, QuickSearch]
        public String ProductSerialNumber
        {
            get { return Fields.ProductSerialNumber[this]; }
            set { Fields.ProductSerialNumber[this] = value; }
        }

        [DisplayName("Service Ticket Id"), Identity]
        public Int32? ServiceTicketId
        {
            get { return Fields.ServiceTicketId[this]; }
            set { Fields.ServiceTicketId[this] = value; }
        }

        [DisplayName("Recorded By User Id"), NotNull]
        public Int32? RecordedByUserId
        {
            get { return Fields.RecordedByUserId[this]; }
            set { Fields.RecordedByUserId[this] = value; }
        }

        [DisplayName("Record Date"), NotNull]
        public DateTime? RecordDate
        {
            get { return Fields.RecordDate[this]; }
            set { Fields.RecordDate[this] = value; }
        }

        [DisplayName("Product Type Id")]
        public Int16? ProductTypeId
        {
            get { return Fields.ProductTypeId[this]; }
            set { Fields.ProductTypeId[this] = value; }
        }

        [DisplayName("Product Mark"), Size(10)]
        public String ProductMark
        {
            get { return Fields.ProductMark[this]; }
            set { Fields.ProductMark[this] = value; }
        }

        [DisplayName("Product Model"), Size(20)]
        public String ProductModel
        {
            get { return Fields.ProductModel[this]; }
            set { Fields.ProductModel[this] = value; }
        }

        [DisplayName("Start Date")]
        public DateTime? StartDate
        {
            get { return Fields.StartDate[this]; }
            set { Fields.StartDate[this] = value; }
        }

        [DisplayName("Finish Date")]
        public DateTime? FinishDate
        {
            get { return Fields.FinishDate[this]; }
            set { Fields.FinishDate[this] = value; }
        }

        [DisplayName("Delivery Date")]
        public DateTime? DeliveryDate
        {
            get { return Fields.DeliveryDate[this]; }
            set { Fields.DeliveryDate[this] = value; }
        }

        [DisplayName("Operation Id")]
        public Int32? OperationId
        {
            get { return Fields.OperationId[this]; }
            set { Fields.OperationId[this] = value; }
        }

        [DisplayName("Stage Id")]
        public Int32? StageId
        {
            get { return Fields.StageId[this]; }
            set { Fields.StageId[this] = value; }
        }

        [DisplayName("Description"), Size(200)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Delivery By User Id")]
        public Int32? DeliveredByUserId
        {
            get { return Fields.DeliveredByUserId[this]; }
            set { Fields.DeliveredByUserId[this] = value; }
        }

        [DisplayName("Customer Id")]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Invoice Number"), Size(10)]
        public String InvoiceNumber
        {
            get { return Fields.InvoiceNumber[this]; }
            set { Fields.InvoiceNumber[this] = value; }
        }

        [DisplayName("Product Desctiption"), Size(200)]
        public String ProductDesctiption
        {
            get { return Fields.ProductDesctiption[this]; }
            set { Fields.ProductDesctiption[this] = value; }
        }

        [DisplayName("Warranty Is Active")]
        public Boolean? WarrantyIsActive
        {
            get { return Fields.WarrantyIsActive[this]; }
            set { Fields.WarrantyIsActive[this] = value; }
        }

        [DisplayName("Warranty Code"), Size(12)]
        public String WarrantyCode
        {
            get { return Fields.WarrantyCode[this]; }
            set { Fields.WarrantyCode[this] = value; }
        }

        [DisplayName("Warranty Source"), Size(30)]
        public String WarrantySource
        {
            get { return Fields.WarrantySource[this]; }
            set { Fields.WarrantySource[this] = value; }
        }

        [DisplayName("Warranty Defination"), Size(50)]
        public String WarrantyDefination
        {
            get { return Fields.WarrantyDefination[this]; }
            set { Fields.WarrantyDefination[this] = value; }
        }

        [DisplayName("State Code"), Size(8)]
        public String StateCode
        {
            get { return Fields.StateCode[this]; }
            set { Fields.StateCode[this] = value; }
        }

        [DisplayName("Symptom Code"), Size(8)]
        public String SymptomCode
        {
            get { return Fields.SymptomCode[this]; }
            set { Fields.SymptomCode[this] = value; }
        }

        [DisplayName("Malfunction Code"), Size(8)]
        public String MalfunctionCode
        {
            get { return Fields.MalfunctionCode[this]; }
            set { Fields.MalfunctionCode[this] = value; }
        }

        [DisplayName("Section Code"), Size(8)]
        public String SectionCode
        {
            get { return Fields.SectionCode[this]; }
            set { Fields.SectionCode[this] = value; }
        }

        [DisplayName("Fix Code"), Size(16)]
        public String FixCode
        {
            get { return Fields.FixCode[this]; }
            set { Fields.FixCode[this] = value; }
        }

        [DisplayName("Purchase Date")]
        public DateTime? PurchaseDate
        {
            get { return Fields.PurchaseDate[this]; }
            set { Fields.PurchaseDate[this] = value; }
        }

        [DisplayName("Mal Function"), Size(200)]
        public String MalFunction
        {
            get { return Fields.MalFunction[this]; }
            set { Fields.MalFunction[this] = value; }
        }

        [DisplayName("Technician Note"), Size(200)]
        public String TechnicianNote
        {
            get { return Fields.TechnicianNote[this]; }
            set { Fields.TechnicianNote[this] = value; }
        }

        [DisplayName("Repair Cost"), Scale(4)]
        public Decimal? RepairCost
        {
            get { return Fields.RepairCost[this]; }
            set { Fields.RepairCost[this] = value; }
        }

        [DisplayName("Labor Cost"), Scale(4)]
        public Decimal? LaborCost
        {
            get { return Fields.LaborCost[this]; }
            set { Fields.LaborCost[this] = value; }
        }

        [DisplayName("Piece Cost"), Scale(4)]
        public Decimal? PieceCost
        {
            get { return Fields.PieceCost[this]; }
            set { Fields.PieceCost[this] = value; }
        }

        [DisplayName("Total Cost"), Scale(4)]
        public Decimal? TotalCost
        {
            get { return Fields.TotalCost[this]; }
            set { Fields.TotalCost[this] = value; }
        }

        [DisplayName("Payment Type Id")]
        public Int16? PaymentTypeId
        {
            get { return Fields.PaymentTypeId[this]; }
            set { Fields.PaymentTypeId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ServiceTicketId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductSerialNumber; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ServiceTicketRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public readonly StringField ProductSerialNumber;
            public readonly Int32Field ServiceTicketId;
            public readonly Int32Field RecordedByUserId;
            public readonly DateTimeField RecordDate;
            public readonly Int16Field ProductTypeId;
            public readonly StringField ProductMark;
            public readonly StringField ProductModel;
            public readonly DateTimeField StartDate;
            public readonly DateTimeField FinishDate;
            public readonly DateTimeField DeliveryDate;
            public readonly Int32Field OperationId;
            public readonly Int32Field StageId;
            public readonly StringField Description;
            public readonly Int32Field DeliveredByUserId;
            public readonly Int32Field CustomerId;
            public readonly StringField InvoiceNumber;
            public readonly StringField ProductDesctiption;
            public readonly BooleanField WarrantyIsActive;
            public readonly StringField WarrantyCode;
            public readonly StringField WarrantySource;
            public readonly StringField WarrantyDefination;
            public readonly StringField StateCode;
            public readonly StringField SymptomCode;
            public readonly StringField MalfunctionCode;
            public readonly StringField SectionCode;
            public readonly StringField FixCode;
            public readonly DateTimeField PurchaseDate;
            public readonly StringField MalFunction;
            public readonly StringField TechnicianNote;
            public readonly DecimalField RepairCost;
            public readonly DecimalField LaborCost;
            public readonly DecimalField PieceCost;
            public readonly DecimalField TotalCost;
            public readonly Int16Field PaymentTypeId;

            public RowFields()
                : base("TvH__ServiceTickets")
            {
                LocalTextPrefix = "TvHastanesi.ServiceTicket";
            }
        }
    }
}