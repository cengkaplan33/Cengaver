
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

    public partial class UnitForm : PrefixedContext
    {
        public UnitForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Unit { get { return ById<StringEditor>("Unit"); } }
        public IntegerEditor UnitTypeId { get { return ById<IntegerEditor>("UnitTypeId"); } }
        public StringEditor Path { get { return ById<StringEditor>("Path"); } }
        public IntegerEditor ManagerId { get { return ById<IntegerEditor>("ManagerId"); } }
        public IntegerEditor FirmId { get { return ById<IntegerEditor>("FirmId"); } }
        public IntegerEditor ParentId { get { return ById<IntegerEditor>("ParentId"); } }
    }
}

