
using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cengaver.Northwind
{
    public partial class PhoneEditorAttribute : CustomEditorAttribute
    {
        public PhoneEditorAttribute()
            : base("Cengaver.Northwind.PhoneEditor")
        {
        }

        public Boolean Multiple
        {
            get { return GetOption<Boolean>("multiple"); }
            set { SetOption("multiple", value); }
        }
    }
}
