
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

    public partial class ShipperForm : PrefixedContext
    {
        public ShipperForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor CompanyName { get { return ById<StringEditor>("CompanyName"); } }
        public StringEditor Phone { get { return ById<StringEditor>("Phone"); } }
    }
}

