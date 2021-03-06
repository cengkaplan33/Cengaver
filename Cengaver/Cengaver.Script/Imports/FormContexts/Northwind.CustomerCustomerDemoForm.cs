
namespace Cengaver.Northwind
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Cengaver.TvHastanesi;

    public partial class CustomerCustomerDemoForm : PrefixedContext
    {
        public CustomerCustomerDemoForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor CustomerID { get { return ById<StringEditor>("CustomerID"); } }
        public StringEditor CustomerTypeID { get { return ById<StringEditor>("CustomerTypeID"); } }
    }
}

