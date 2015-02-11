
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

    public partial class UnitForm : PrefixedContext
    {
        public UnitForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Unit { get { return ById<StringEditor>("Unit"); } }
        public IntegerEditor UnitTypeId { get { return ById<IntegerEditor>("UnitTypeId"); } }
        public StringEditor Path { get { return ById<StringEditor>("Path"); } }
        public IntegerEditor InsertUserId { get { return ById<IntegerEditor>("InsertUserId"); } }
        public DateEditor InsertDate { get { return ById<DateEditor>("InsertDate"); } }
        public BooleanEditor IsActive { get { return ById<BooleanEditor>("IsActive"); } }
        public IntegerEditor UpdateUserId { get { return ById<IntegerEditor>("UpdateUserId"); } }
        public DateEditor UpdateDate { get { return ById<DateEditor>("UpdateDate"); } }
        public IntegerEditor ManagerId { get { return ById<IntegerEditor>("ManagerId"); } }
        public IntegerEditor FirmId { get { return ById<IntegerEditor>("FirmId"); } }
        public IntegerEditor ParentId { get { return ById<IntegerEditor>("ParentId"); } }
    }
}

