
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("TvHastanesi.Customer"), IdProperty("CustomerId"), NameProperty("Name"), IsActiveProperty("IsActive")]
    [DialogType(typeof(CustomerDialog)), LocalTextPrefix("TvHastanesi.Customer"), Service("TvHastanesi/Customer")]
    public class CustomerGrid : EntityGrid<CustomerRow>
    {
        public CustomerGrid(jQueryObject container)
            : base(container)
        {
        }
    }

    public partial class EditorItem
    {
        public Int32 id;
        public String text;
        public bool disabled;
    }
}