
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

    public partial class TerritoryForm : PrefixedContext
    {
        public TerritoryForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor TerritoryID { get { return ById<StringEditor>("TerritoryID"); } }
        public StringEditor TerritoryDescription { get { return ById<StringEditor>("TerritoryDescription"); } }
        public LookupEditor RegionID { get { return ById<LookupEditor>("RegionID"); } }
    }
}

