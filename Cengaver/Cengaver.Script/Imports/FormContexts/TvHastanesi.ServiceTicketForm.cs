
namespace Cengaver.TvHastanesi
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Cengaver.TvHastanesi;

    public partial class ServiceTicketForm : PrefixedContext
    {
        public ServiceTicketForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor ProductSerialNumber { get { return ById<StringEditor>("ProductSerialNumber"); } }
        public StringEditor ProductMark { get { return ById<StringEditor>("ProductMark"); } }
        public StringEditor ProductModel { get { return ById<StringEditor>("ProductModel"); } }
        public TextAreaEditor ProductDesctiption { get { return ById<TextAreaEditor>("ProductDesctiption"); } }
        public DateEditor PurchaseDate { get { return ById<DateEditor>("PurchaseDate"); } }
        public BooleanEditor WarrantyIsActive { get { return ById<BooleanEditor>("WarrantyIsActive"); } }
        public StringEditor WarrantyCode { get { return ById<StringEditor>("WarrantyCode"); } }
        public StringEditor WarrantySource { get { return ById<StringEditor>("WarrantySource"); } }
        public StringEditor WarrantyDefination { get { return ById<StringEditor>("WarrantyDefination"); } }
        public StringEditor InvoiceNumber { get { return ById<StringEditor>("InvoiceNumber"); } }
        public DateEditor RecordDate { get { return ById<DateEditor>("RecordDate"); } }
        public DateEditor DeliveryDate { get { return ById<DateEditor>("DeliveryDate"); } }
        public IntegerEditor OperationId { get { return ById<IntegerEditor>("OperationId"); } }
        public IntegerEditor StageId { get { return ById<IntegerEditor>("StageId"); } }
        public TextAreaEditor Description { get { return ById<TextAreaEditor>("Description"); } }
        public CustomerEditor CustomerId { get { return ById<CustomerEditor>("CustomerId"); } }
        public LookupEditor RecordedByUserId { get { return ById<LookupEditor>("RecordedByUserId"); } }
        public LookupEditor DeliveredByUserId { get { return ById<LookupEditor>("DeliveredByUserId"); } }
        public TextAreaEditor MalFunction { get { return ById<TextAreaEditor>("MalFunction"); } }
        public DateEditor StartDate { get { return ById<DateEditor>("StartDate"); } }
        public DateEditor FinishDate { get { return ById<DateEditor>("FinishDate"); } }
        public TextAreaEditor TechnicianNote { get { return ById<TextAreaEditor>("TechnicianNote"); } }
        public StringEditor StateCode { get { return ById<StringEditor>("StateCode"); } }
        public StringEditor SymptomCode { get { return ById<StringEditor>("SymptomCode"); } }
        public StringEditor MalfunctionCode { get { return ById<StringEditor>("MalfunctionCode"); } }
        public StringEditor SectionCode { get { return ById<StringEditor>("SectionCode"); } }
        public DecimalEditor RepairCost { get { return ById<DecimalEditor>("RepairCost"); } }
        public DecimalEditor LaborCost { get { return ById<DecimalEditor>("LaborCost"); } }
        public DecimalEditor PieceCost { get { return ById<DecimalEditor>("PieceCost"); } }
        public StringEditor TotalCost { get { return ById<StringEditor>("TotalCost"); } }
        public EnumEditor PaymentTypeId { get { return ById<EnumEditor>("PaymentTypeId"); } }
    }
}

