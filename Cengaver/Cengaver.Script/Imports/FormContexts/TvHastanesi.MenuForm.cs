
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

    public partial class MenuForm : PrefixedContext
    {
        public MenuForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Menu { get { return ById<StringEditor>("Menu"); } }
        public IntegerEditor DisplayOrder { get { return ById<IntegerEditor>("DisplayOrder"); } }
        public IntegerEditor FirmId { get { return ById<IntegerEditor>("FirmId"); } }
        public IntegerEditor WebSiteId { get { return ById<IntegerEditor>("WebSiteId"); } }
        public StringEditor Path { get { return ById<StringEditor>("Path"); } }
        public StringEditor Url { get { return ById<StringEditor>("Url"); } }
        public IntegerEditor InsertUserId { get { return ById<IntegerEditor>("InsertUserId"); } }
        public DateEditor InsertDate { get { return ById<DateEditor>("InsertDate"); } }
        public BooleanEditor IsActive { get { return ById<BooleanEditor>("IsActive"); } }
        public IntegerEditor UpdateUserId { get { return ById<IntegerEditor>("UpdateUserId"); } }
        public DateEditor UpdateDate { get { return ById<DateEditor>("UpdateDate"); } }
        public IntegerEditor ParentId { get { return ById<IntegerEditor>("ParentId"); } }
        public IntegerEditor RootId { get { return ById<IntegerEditor>("RootId"); } }
    }
}

