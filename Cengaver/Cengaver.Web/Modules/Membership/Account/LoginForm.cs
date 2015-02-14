
namespace Cengaver.Membership.Forms
{
    using System;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System.Collections.Generic;
    using System.ComponentModel;

    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(Administration.Entities.UserRow))]
    public class LoginForm
    {
        [Placeholder("username")]
        public String Username { get; set; }
        [PasswordEditor, Placeholder("password"), Required(true)]
        public String Password { get; set; }
    }
}