
namespace Cengaver.TvHastanesi
{
    public class PermissionKeys
    {
        public class City
        {
            //public const string Delete = "CengKaplan:CommonDefinition:City:Delete";
            //public const string Modify = "CengKaplan:CommonDefinition:City:Modify";
            //public const string View = "CengKaplan:CommonDefinition:City:View";
        }

        public class County
        {
            //public const string Delete = "CengKaplan:CommonDefinition:County:Delete";
            //public const string Modify = "CengKaplan:CommonDefinition:County:Modify";
            //public const string View = "CengKaplan:CommonDefinition:County:View";
        }

        /*
         TODO:: şimdilik sadece bunu kullanacağım. üstteki yetkiler ise derinlemesine bir tasarımda kullanılacak
         bu tanımların burada olmasının hiçbir önemi yok.çünkü kullanıldığı yer var ise reflection ile adı alınıyor.
         */

        public const string ServiceRegistry = "Cengaver:TvHastanesi:ServiceRegistry";
        public const string Reseller = "Cengaver:TvHastanesi:Reseller";
        public const string Admin = "Cengaver:TvHastanesi:Admin";
        public const string Developer = "Cengaver:TvHastanesi:Developer";
    }
}
