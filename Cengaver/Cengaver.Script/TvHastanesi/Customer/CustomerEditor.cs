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
           // Q.Alert("ççç");
        }

        protected override string GetItemText(CustomerRow item, Lookup<CustomerRow> lookup)
        {
            return base.GetItemText(item, lookup) + " - (" + item.PhoneNumber + ")";
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

        protected override Select2Options GetSelect2Options()
        {

            //search item ların sayısına göre search kutusunu gösterir.
            var opt = base.GetSelect2Options();
            opt.MinimumResultsForSearch = 0;
            return opt;
        }
    }
}