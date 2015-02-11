
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("MenuId"), NameProperty("Menu"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.Menu"), LocalTextPrefix("TvHastanesi.Menu"), Service("TvHastanesi/Menu")]
    public class MenuDialog : EntityDialog<MenuRow>
    {
    }
}