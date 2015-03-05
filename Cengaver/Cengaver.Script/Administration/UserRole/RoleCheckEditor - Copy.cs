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

    [Editor]
    public class CustomerEditor : LookupEditorBase<CustomerRow>
    {
        public CustomerEditor(jQueryObject hidden)
            : base(hidden)
        {
            Q.Alert("ççç");
        }

        protected override string GetItemText(CustomerRow item, Lookup<CustomerRow> lookup)
        {
            return base.GetItemText(item, lookup) + "(" + item.PhoneNumber + ")";
        } // bu kadar  
        //hazır buradasın abi bir teste edeyim  :)

        protected override string GetLookupKey()
        {
            //ok abi şimdi anladıpım kadarıyla isiimler aynıolursa benim editorü direk buluyor.
            //[LookupScript("TvHastanesi.Customer")]
            return "TvHastanesi.Customer"; // burayla aynı olacak o 
            // editör keyin in Cengaver.TvHastanesi.CustomerEditor
            // veya Cengaver root namespace olduğundan
            // TvHastanesi.CustomerEditor
            //TvHastanesi.Customer
            // Customer da olabilir
            // ama en garantisi full namespace
            // bunların hepsi çalışır
            // fakat sen string yazma
            // .tt yi kullan

        }
    }
}