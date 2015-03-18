
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

    public partial class ServiceChargeForm : PrefixedContext
    {
        public ServiceChargeForm(string idPrefix) : base(idPrefix) {}
    
        public IntegerEditor ChargeId { get { return ById<IntegerEditor>("ChargeId"); } }
        public IntegerEditor ServiceTicketId { get { return ById<IntegerEditor>("ServiceTicketId"); } }
        public IntegerEditor InsertUserId { get { return ById<IntegerEditor>("InsertUserId"); } }
        public DateEditor InsertDate { get { return ById<DateEditor>("InsertDate"); } }
        public StringEditor IsActive { get { return ById<StringEditor>("IsActive"); } }
        public IntegerEditor UpdateUserId { get { return ById<IntegerEditor>("UpdateUserId"); } }
        public DateEditor UpdateDate { get { return ById<DateEditor>("UpdateDate"); } }
        public StringEditor TaxRate { get { return ById<StringEditor>("TaxRate"); } }
        public BooleanEditor TaxIncluded { get { return ById<BooleanEditor>("TaxIncluded"); } }
        public DecimalEditor UnitPrice { get { return ById<DecimalEditor>("UnitPrice"); } }
        public DecimalEditor TotalTaxAmount { get { return ById<DecimalEditor>("TotalTaxAmount"); } }
        public DecimalEditor TotalAmount { get { return ById<DecimalEditor>("TotalAmount"); } }
        public EnumEditor Type { get { return ById<EnumEditor>("Type"); } }
    }
}

