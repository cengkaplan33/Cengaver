
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

    public partial class CityForm : PrefixedContext
    {
        public CityForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor City { get { return ById<StringEditor>("City"); } }
    }
}

