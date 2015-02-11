
namespace Cengaver.TvHastanesi
{
    using jQueryApi;
using Serenity;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

    [IdProperty("CustomerId"), NameProperty("Name"), IsActiveProperty("IsActive")]
    [FormKey("TvHastanesi.Customer"), LocalTextPrefix("TvHastanesi.Customer"), Service("TvHastanesi/Customer")]
    public class CustomerDialog : EntityDialog<CustomerRow>
    {

        public CustomerDialog(UserRoleDialogOptionsw op)
            : base()
        {
            //jQueryEventHandler changeSiteId = delegate(jQueryEvent e)
            //{
            //    new UserTypeEditor(this.ById("UserTypeId"), new UserTypeEditorOptions() { SiteId = int.Parse(B2CSiteSettingEditor.From(this.ById("SiteId")).Value.ToString()) });
            //};

            //this.ById("SiteId").bind("change", changeSiteId).bind("updateDependents", changeSiteId);

            new CustomerEditor(this.ById("UpdateUserId"));
        }
    }

        [Imported, Serializable]
    public class UserRoleDialogOptionsw
    {
        public int UserID { get; set; }
        public string Username { get; set; }
    }
}