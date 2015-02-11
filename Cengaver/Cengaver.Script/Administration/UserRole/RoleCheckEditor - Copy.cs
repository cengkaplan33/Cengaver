//using jQueryApi;
//using Serenity;
//using System.Collections.Generic;

//namespace Cengaver.TvHastanesi
//{
//    [Editor]
//    [ColumnsKey("TvHastanesi.Customer"), IdProperty("CustomerId"), NameProperty("Name")]
//    [DialogType(typeof(TvHastanesi.CustomerDialog)), LocalTextPrefix("TvHastanesi.Customer"), Service("TvHastanesi/Customer")]
//    public class CustomerEditor : SelectEditor
//    {
//        public CustomerEditor(jQueryObject hidden, SelectEditorOptions opt)
//            :base (hidden,opt)
//        {

//          //  Q.Alert("asdsadas");

//        }

//        protected override List<object> GetItems()
//        {
//            //TODO::OK::Check:: bu yemedi nedeni öğrenilecek
//            //var permissions = Q.GetRemoteData<ListResponse<CustomerRow>>("TvHastanesi.Customer").Entities;

//            var permissions = Q.GetLookup<CustomerRow>("TvHastanesi.Customer").Items;
//            var rrrrrrrrrr = "";
//            return new List<object>() { permissions };
//        }
//    }
//}

namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using Serenity.ComponentModel;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    [Editor, DisplayName("Kampüs")]
    public class CustomerEditor : LookupEditorBase<object, CustomerRow>
    {
        public CustomerEditor(jQueryObject select)
            : base(select, new object())
        {
        }
    }
}