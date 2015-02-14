
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
    using Cengaver.Northwind;

    public partial class ServiceTicketForm : PrefixedContext
    {
        public ServiceTicketForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor ProductSerialNumber { get { return ById<StringEditor>("ProductSerialNumber"); } }
        public StringEditor ProductTypeId { get { return ById<StringEditor>("ProductTypeId"); } }
        public StringEditor ProductMark { get { return ById<StringEditor>("ProductMark"); } }
        public StringEditor ProductModel { get { return ById<StringEditor>("ProductModel"); } }
        public StringEditor ProductDesctiption { get { return ById<StringEditor>("ProductDesctiption"); } }
        public StringEditor InvoiceNumber { get { return ById<StringEditor>("InvoiceNumber"); } }
        public DateEditor ReceiveDate { get { return ById<DateEditor>("ReceiveDate"); } }
        public DateEditor DeliveryDate { get { return ById<DateEditor>("DeliveryDate"); } }
        public IntegerEditor OperationId { get { return ById<IntegerEditor>("OperationId"); } }
        public IntegerEditor StageId { get { return ById<IntegerEditor>("StageId"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor CustomerId { get { return ById<IntegerEditor>("CustomerId"); } }
        public StringEditor MalFunction { get { return ById<StringEditor>("MalFunction"); } }
        public StringEditor TechnicianNote { get { return ById<StringEditor>("TechnicianNote"); } }
        public DecimalEditor RepairCost { get { return ById<DecimalEditor>("RepairCost"); } }
        public DecimalEditor LaborCost { get { return ById<DecimalEditor>("LaborCost"); } }
        public DecimalEditor PieceCost { get { return ById<DecimalEditor>("PieceCost"); } }
        public StringEditor TotalCost { get { return ById<StringEditor>("TotalCost"); } }
        public StringEditor PaymentTypeId { get { return ById<StringEditor>("PaymentTypeId"); } }
    }
}

