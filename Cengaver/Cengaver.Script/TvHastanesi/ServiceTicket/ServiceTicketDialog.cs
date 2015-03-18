
namespace Cengaver.TvHastanesi
{
    using Cengaver.TvHastanesi.Enums;
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

            jQueryObject registrationForm = this.toolbar.FindButton(".s-ServiceRegistrationTechnicianForm").Toggle(this.IsEditMode);

            if (this.IsEditMode)
            {
                registrationForm.Html("<div class=\"button-outer\"> "
                    + "<a style=\"display: block;\" target=\"_blank\" href=\""
                    + Q.ResolveUrl("~/TvHastanesi/ServiceTicketForm?ServiceTicketId=") + this.EntityId + "&FormType=" + ServiceTicketFormType.RegistrationTechnician + "\"> <span class=\"button-inner\" >"
                    + " Teknisyen Formu </span></a></div>");
            }

            jQueryObject registrationUserForm = this.toolbar.FindButton(".s-ServiceRegistrationUserForm").Toggle(this.IsEditMode);

            if (this.IsEditMode)
            {
                registrationUserForm.Html("<div class=\"button-outer\"> "
                    + "<a style=\"display: block;\" target=\"_blank\" href=\""
                    + Q.ResolveUrl("~/TvHastanesi/ServiceTicketForm?ServiceTicketId=") + this.EntityId + "&FormType=" + ServiceTicketFormType.RegistationUser + "\"> <span class=\"button-inner\" >"
                    + " Müşteri Formu </span></a></div>");
            }

            jQueryObject uretim = this.toolbar.FindButton(".s-SonyKrediFaturaButton").Toggle(this.IsEditMode);

            if (this.IsEditMode)
            {
                uretim.Html("<div class=\"button-outer\"> "
                    + "<a style=\"display: block;\" target=\"_blank\" href=\""
                    //+ Q.ResolveUrl("~/TvHastanesi/SonyKrediFaturaReport?serviceTicketId=") + this.EntityId + "&FormType=" + ServiceTicketFormType.Sony + "\"> <span class=\"button-inner\" >"
                    + Q.ResolveUrl("~/TvHastanesi/ServiceTicketForm?serviceTicketId=") + this.EntityId + "&FormType=" + ServiceTicketFormType.Sony + "\"> <span class=\"button-inner\" >"
                    + " Servis Faturası </span></a></div>");
            }

            AfterLoadEntity_ShowHideFields();
        }

        private void AfterLoadEntity_ShowHideFields()
        {
            if (!this.IsEditMode)
            {
                ById("StartDate").Closest("div.category").Hide();
                ById("RepairCost").Closest("div.category").Hide();
            }
        }

        protected override List<ToolButton> GetToolbarButtons()
        {
            List<ToolButton> buttons = base.GetToolbarButtons();

            buttons.Add(new ToolButton
            {
                Title = "Müşteri Formu",
                CssClass = "s-ServiceRegistrationUserForm print-preview-button",
                OnClick = delegate { }
            });

            buttons.Add(new ToolButton
            {
                Title = "Teknisyen Formu",
                CssClass = "s-ServiceRegistrationTechnicianForm print-preview-button",
                OnClick = delegate { }
            });

            buttons.Add(new ToolButton
            {
                Title = "Servis Faturası",
                CssClass = "s-SonyKrediFaturaButton print-preview-button",
                OnClick = delegate { }
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