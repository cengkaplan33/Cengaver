
namespace Cengaver.TvHastanesi
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Cengaver.Northwind;

    public partial class ServiceTicketsForm : PrefixedContext
    {
        public ServiceTicketsForm(string idPrefix) : base(idPrefix) {}
    
        public DateEditor ReceiveDate { get { return ById<DateEditor>("ReceiveDate"); } }
        public StringEditor ProductSerialNumber { get { return ById<StringEditor>("ProductSerialNumber"); } }
        public IntegerEditor InsertUserId { get { return ById<IntegerEditor>("InsertUserId"); } }
        public DateEditor InsertDate { get { return ById<DateEditor>("InsertDate"); } }
        public StringEditor ProductTypeId { get { return ById<StringEditor>("ProductTypeId"); } }
        public BooleanEditor IsActive { get { return ById<BooleanEditor>("IsActive"); } }
        public StringEditor ProductMark { get { return ById<StringEditor>("ProductMark"); } }
        public StringEditor ProductModel { get { return ById<StringEditor>("ProductModel"); } }
        public IntegerEditor UpdateUserId { get { return ById<IntegerEditor>("UpdateUserId"); } }
        public DateEditor UpdateDate { get { return ById<DateEditor>("UpdateDate"); } }
        public StringEditor ProductDesctiption { get { return ById<StringEditor>("ProductDesctiption"); } }
        public StringEditor MalFunction { get { return ById<StringEditor>("MalFunction"); } }
        public StringEditor TechnicianNote { get { return ById<StringEditor>("TechnicianNote"); } }
        public DecimalEditor RepairCost { get { return ById<DecimalEditor>("RepairCost"); } }
        public DecimalEditor LaborCost { get { return ById<DecimalEditor>("LaborCost"); } }
        public DecimalEditor PieceCost { get { return ById<DecimalEditor>("PieceCost"); } }
        public StringEditor TotalCost { get { return ById<StringEditor>("TotalCost"); } }
        public StringEditor PaymentTypeId { get { return ById<StringEditor>("PaymentTypeId"); } }
        public DateEditor DeliveryDate { get { return ById<DateEditor>("DeliveryDate"); } }
        public IntegerEditor OperationId { get { return ById<IntegerEditor>("OperationId"); } }
        public IntegerEditor StageId { get { return ById<IntegerEditor>("StageId"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public LookupEditor CustomerId { get { return ById<LookupEditor>("CustomerId"); } }
        public StringEditor InvoiceNumber { get { return ById<StringEditor>("InvoiceNumber"); } }
        public StringEditor RecordDate { get { return ById<StringEditor>("RecordDate"); } }
    }
}

