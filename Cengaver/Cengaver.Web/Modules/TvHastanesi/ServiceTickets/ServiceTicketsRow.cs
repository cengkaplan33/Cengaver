
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
    [DeletePermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.General)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class ServiceTicketsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Service Ticket Id"), Identity]
        public Int32? ServiceTicketId
        {
            get { return Fields.ServiceTicketId[this]; }
            set { Fields.ServiceTicketId[this] = value; }
        }

        [DisplayName("Receive Date"), NotNull]
        public DateTime? ReceiveDate
        {
            get { return Fields.ReceiveDate[this]; }
            set { Fields.ReceiveDate[this] = value; }
        }

        [DisplayName("Product Serial Number"), Size(10), NotNull, QuickSearch]
        public String ProductSerialNumber
        {
            get { return Fields.ProductSerialNumber[this]; }
            set { Fields.ProductSerialNumber[this] = value; }
        }

        [DisplayName("Insert User Id"), NotNull]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Product Type Id"), NotNull]
        public Int16? ProductTypeId
        {
            get { return Fields.ProductTypeId[this]; }
            set { Fields.ProductTypeId[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
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

        [DisplayName("Update User Id")]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Product Desctiption"), Size(200)]
        public String ProductDesctiption
        {
            get { return Fields.ProductDesctiption[this]; }
            set { Fields.ProductDesctiption[this] = value; }
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

        [DisplayName("Total Cost"), Size(10)]
        public String TotalCost
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

        [DisplayName("Record Date"), Size(10)]
        public String RecordDate
        {
            get { return Fields.RecordDate[this]; }
            set { Fields.RecordDate[this] = value; }
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

        public ServiceTicketsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field ServiceTicketId;
            public readonly DateTimeField ReceiveDate;
            public readonly StringField ProductSerialNumber;
            public readonly Int32Field InsertUserId;
            public readonly DateTimeField InsertDate;
            public readonly Int16Field ProductTypeId;
            public readonly BooleanField IsActive;
            public readonly StringField ProductMark;
            public readonly StringField ProductModel;
            public readonly Int32Field UpdateUserId;
            public readonly DateTimeField UpdateDate;
            public readonly StringField ProductDesctiption;
            public readonly StringField MalFunction;
            public readonly StringField TechnicianNote;
            public readonly DecimalField RepairCost;
            public readonly DecimalField LaborCost;
            public readonly DecimalField PieceCost;
            public readonly StringField TotalCost;
            public readonly Int16Field PaymentTypeId;
            public readonly DateTimeField DeliveryDate;
            public readonly Int32Field OperationId;
            public readonly Int32Field StageId;
            public readonly StringField Description;
            public readonly Int32Field CustomerId;
            public readonly StringField InvoiceNumber;
            public readonly StringField RecordDate;

            public RowFields()
                : base("TvH__ServiceTickets")
            {
                LocalTextPrefix = "TvHastanesi.ServiceTickets";
            }
        }
    }
}