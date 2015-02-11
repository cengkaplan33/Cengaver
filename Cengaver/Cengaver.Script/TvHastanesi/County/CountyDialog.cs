
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("CountyId"), NameProperty("County")]
    [FormKey("TvHastanesi.County"), LocalTextPrefix("TvHastanesi.County"), Service("TvHastanesi/County")]
    public class CountyDialog : EntityDialog<CountyRow>
    {
    }
}