
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

    public partial class MenuForm : PrefixedContext
    {
        public MenuForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Menu { get { return ById<StringEditor>("Menu"); } }
        public IntegerEditor DisplayOrder { get { return ById<IntegerEditor>("DisplayOrder"); } }
        public IntegerEditor FirmId { get { return ById<IntegerEditor>("FirmId"); } }
        public IntegerEditor WebSiteId { get { return ById<IntegerEditor>("WebSiteId"); } }
        public StringEditor Path { get { return ById<StringEditor>("Path"); } }
        public StringEditor Url { get { return ById<StringEditor>("Url"); } }
        public IntegerEditor ParentId { get { return ById<IntegerEditor>("ParentId"); } }
        public IntegerEditor RootId { get { return ById<IntegerEditor>("RootId"); } }
    }
}

