
namespace Cengaver.Northwind
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Cengaver.Northwind;

    public partial class ShipperForm : PrefixedContext
    {
        public ShipperForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor CompanyName { get { return ById<StringEditor>("CompanyName"); } }
        public PhoneEditor Phone { get { return ById<PhoneEditor>("Phone"); } }
    }
}

