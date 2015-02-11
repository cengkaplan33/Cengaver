
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

    public partial class CountyForm : PrefixedContext
    {
        public CountyForm(string idPrefix) : base(idPrefix) {}
    
        public LookupEditor CityId { get { return ById<LookupEditor>("CityId"); } }
        public StringEditor County { get { return ById<StringEditor>("County"); } }
    }
}

