
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
    public partial class ServiceTicketRow
    {
        public String ProductSerialNumber { get; set; }
        public Int32? ServiceTicketId { get; set; }
        public String RecordDate { get; set; }
        public Int16? ProductTypeId { get; set; }
        public String ProductMark { get; set; }
        public String ProductModel { get; set; }
        public String StartDate { get; set; }
        public String FinishDate { get; set; }
        public String DeliveryDate { get; set; }
        public Int32? OperationId { get; set; }
        public Int32? StageId { get; set; }
        public String Description { get; set; }
        public String InvoiceNumber { get; set; }
        public String ProductDesctiption { get; set; }
        public Boolean? WarrantyIsActive { get; set; }
        public String WarrantyCode { get; set; }
        public String WarrantySource { get; set; }
        public String WarrantyDefination { get; set; }
        public String StateCode { get; set; }
        public String SymptomCode { get; set; }
        public String MalfunctionCode { get; set; }
        public String SectionCode { get; set; }
        public String FixCode { get; set; }
        public String PurchaseDate { get; set; }
        public String MalFunction { get; set; }
        public String TechnicianNote { get; set; }
        public Decimal? RepairCost { get; set; }
        public Decimal? LaborCost { get; set; }
        public Decimal? PieceCost { get; set; }
        public Decimal? TotalCost { get; set; }
        public Int16? PaymentTypeId { get; set; }
        public Int32? RecordedByUserId { get; set; }
        public String RecordedByUserDisplayName { get; set; }
        public Int32? CustomerId { get; set; }
        public String CustomerName { get; set; }
        public String CustomerSurname { get; set; }
        public Int32? DeliveredByUserId { get; set; }
        public String DeliveredByUserDisplayName { get; set; }
        public Int32? InsertUserId { get; set; }
        public String InsertDate { get; set; }
        public Int32? UpdateUserId { get; set; }
        public String UpdateDate { get; set; }
        public Int16? IsActive { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string ProductSerialNumber = "ProductSerialNumber";
            [InlineConstant] public const string ServiceTicketId = "ServiceTicketId";
            [InlineConstant] public const string RecordDate = "RecordDate";
            [InlineConstant] public const string ProductTypeId = "ProductTypeId";
            [InlineConstant] public const string ProductMark = "ProductMark";
            [InlineConstant] public const string ProductModel = "ProductModel";
            [InlineConstant] public const string StartDate = "StartDate";
            [InlineConstant] public const string FinishDate = "FinishDate";
            [InlineConstant] public const string DeliveryDate = "DeliveryDate";
            [InlineConstant] public const string OperationId = "OperationId";
            [InlineConstant] public const string StageId = "StageId";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string InvoiceNumber = "InvoiceNumber";
            [InlineConstant] public const string ProductDesctiption = "ProductDesctiption";
            [InlineConstant] public const string WarrantyIsActive = "WarrantyIsActive";
            [InlineConstant] public const string WarrantyCode = "WarrantyCode";
            [InlineConstant] public const string WarrantySource = "WarrantySource";
            [InlineConstant] public const string WarrantyDefination = "WarrantyDefination";
            [InlineConstant] public const string StateCode = "StateCode";
            [InlineConstant] public const string SymptomCode = "SymptomCode";
            [InlineConstant] public const string MalfunctionCode = "MalfunctionCode";
            [InlineConstant] public const string SectionCode = "SectionCode";
            [InlineConstant] public const string FixCode = "FixCode";
            [InlineConstant] public const string PurchaseDate = "PurchaseDate";
            [InlineConstant] public const string MalFunction = "MalFunction";
            [InlineConstant] public const string TechnicianNote = "TechnicianNote";
            [InlineConstant] public const string RepairCost = "RepairCost";
            [InlineConstant] public const string LaborCost = "LaborCost";
            [InlineConstant] public const string PieceCost = "PieceCost";
            [InlineConstant] public const string TotalCost = "TotalCost";
            [InlineConstant] public const string PaymentTypeId = "PaymentTypeId";
            [InlineConstant] public const string RecordedByUserId = "RecordedByUserId";
            [InlineConstant] public const string RecordedByUserDisplayName = "RecordedByUserDisplayName";
            [InlineConstant] public const string CustomerId = "CustomerId";
            [InlineConstant] public const string CustomerName = "CustomerName";
            [InlineConstant] public const string CustomerSurname = "CustomerSurname";
            [InlineConstant] public const string DeliveredByUserId = "DeliveredByUserId";
            [InlineConstant] public const string DeliveredByUserDisplayName = "DeliveredByUserDisplayName";
            [InlineConstant] public const string InsertUserId = "InsertUserId";
            [InlineConstant] public const string InsertDate = "InsertDate";
            [InlineConstant] public const string UpdateUserId = "UpdateUserId";
            [InlineConstant] public const string UpdateDate = "UpdateDate";
            [InlineConstant] public const string IsActive = "IsActive";
        }
    }
    
}

