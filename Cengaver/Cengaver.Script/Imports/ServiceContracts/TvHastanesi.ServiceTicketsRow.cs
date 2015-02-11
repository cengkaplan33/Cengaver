
namespace Cengaver.TvHastanesi
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class ServiceTicketsRow
    {
        public Int32? ServiceTicketId { get; set; }
        public String ReceiveDate { get; set; }
        public String ProductSerialNumber { get; set; }
        public Int32? InsertUserId { get; set; }
        public String InsertDate { get; set; }
        public Int16? ProductTypeId { get; set; }
        public Boolean? IsActive { get; set; }
        public String ProductMark { get; set; }
        public String ProductModel { get; set; }
        public Int32? UpdateUserId { get; set; }
        public String UpdateDate { get; set; }
        public String ProductDesctiption { get; set; }
        public String MalFunction { get; set; }
        public String TechnicianNote { get; set; }
        public Decimal? RepairCost { get; set; }
        public Decimal? LaborCost { get; set; }
        public Decimal? PieceCost { get; set; }
        public String TotalCost { get; set; }
        public Int16? PaymentTypeId { get; set; }
        public String DeliveryDate { get; set; }
        public Int32? OperationId { get; set; }
        public Int32? StageId { get; set; }
        public String Description { get; set; }
        public Int32? CustomerId { get; set; }
        public String InvoiceNumber { get; set; }
        public String RecordDate { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string ServiceTicketId = "ServiceTicketId";
            [InlineConstant] public const string ReceiveDate = "ReceiveDate";
            [InlineConstant] public const string ProductSerialNumber = "ProductSerialNumber";
            [InlineConstant] public const string InsertUserId = "InsertUserId";
            [InlineConstant] public const string InsertDate = "InsertDate";
            [InlineConstant] public const string ProductTypeId = "ProductTypeId";
            [InlineConstant] public const string IsActive = "IsActive";
            [InlineConstant] public const string ProductMark = "ProductMark";
            [InlineConstant] public const string ProductModel = "ProductModel";
            [InlineConstant] public const string UpdateUserId = "UpdateUserId";
            [InlineConstant] public const string UpdateDate = "UpdateDate";
            [InlineConstant] public const string ProductDesctiption = "ProductDesctiption";
            [InlineConstant] public const string MalFunction = "MalFunction";
            [InlineConstant] public const string TechnicianNote = "TechnicianNote";
            [InlineConstant] public const string RepairCost = "RepairCost";
            [InlineConstant] public const string LaborCost = "LaborCost";
            [InlineConstant] public const string PieceCost = "PieceCost";
            [InlineConstant] public const string TotalCost = "TotalCost";
            [InlineConstant] public const string PaymentTypeId = "PaymentTypeId";
            [InlineConstant] public const string DeliveryDate = "DeliveryDate";
            [InlineConstant] public const string OperationId = "OperationId";
            [InlineConstant] public const string StageId = "StageId";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string CustomerId = "CustomerId";
            [InlineConstant] public const string InvoiceNumber = "InvoiceNumber";
            [InlineConstant] public const string RecordDate = "RecordDate";
        }
    }
    
}

