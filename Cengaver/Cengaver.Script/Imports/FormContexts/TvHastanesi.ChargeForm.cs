
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

    public partial class ChargeForm : PrefixedContext
    {
        public ChargeForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Charge { get { return ById<StringEditor>("Charge"); } }
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor TaxRate { get { return ById<StringEditor>("TaxRate"); } }
        public BooleanEditor TaxIncluded { get { return ById<BooleanEditor>("TaxIncluded"); } }
        public DecimalEditor Price { get { return ById<DecimalEditor>("Price"); } }
        public EnumEditor Type { get { return ById<EnumEditor>("Type"); } }
    }
}

