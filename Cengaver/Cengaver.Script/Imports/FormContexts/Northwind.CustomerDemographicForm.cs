
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
    using Cengaver.Northwind;

    public partial class CustomerDemographicForm : PrefixedContext
    {
        public CustomerDemographicForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor CustomerTypeID { get { return ById<StringEditor>("CustomerTypeID"); } }
        public StringEditor CustomerDesc { get { return ById<StringEditor>("CustomerDesc"); } }
    }
}

