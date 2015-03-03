
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("ServiceTicketId"), NameProperty("ProductSerialNumber"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.ServiceTicket"), LocalTextPrefix("TvHastanesi.ServiceTicket"), Service("TvHastanesi/ServiceTicket")]
    public class ServiceTicketDialog : EntityDialog<ServiceTicketRow>
    {
        protected override void AfterLoadEntity()
        {
            base.AfterLoadEntity();

            jQueryObject uretim = this.toolbar.FindButton(".s-SonyKrediFaturaButton").Toggle(this.IsEditMode);

            if (this.IsEditMode)
            {
                uretim.Html("<div class=\"button-outer\"> "
                    + "<a style=\"display: block;\" target=\"_blank\" href=\""
                    + Q.ResolveUrl("~/TvHastanesi/SonyKrediFaturaReport?serviceTicketId=") + this.EntityId + "\"> <span class=\"button-inner\" >"
                    + " Servis Faturası </span></a></div>");
            }
        }

        protected override List<ToolButton> GetToolbarButtons()
        {
            List<ToolButton> buttons = base.GetToolbarButtons();

            buttons.Add(new ToolButton
            {
                Title = "Servis Faturası",
                CssClass = "s-SonyKrediFaturaButton print-preview-button",
                OnClick = delegate
                {

                }
            });

            return buttons;
        }

        protected override void UpdateInterface()
        {
            base.UpdateInterface();

            toolbar.FindButton("s-SonyKrediFaturaButton").ToggleClass("disabled", this.IsNewOrDeleted);
        }
    }
}