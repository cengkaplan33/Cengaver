
using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cengaver.Administration
{
    public partial class PermissionCheckEditorAttribute : CustomEditorAttribute
    {
        public PermissionCheckEditorAttribute()
            : base("Cengaver.Administration.PermissionCheckEditor")
        {
        }
    }

    public partial class PermissionModuleEditorAttribute : CustomEditorAttribute
    {
        public PermissionModuleEditorAttribute()
            : base("Cengaver.Administration.PermissionModuleEditor")
        {
        }
    }

    public partial class RoleCheckEditorAttribute : CustomEditorAttribute
    {
        public RoleCheckEditorAttribute()
            : base("Cengaver.Administration.RoleCheckEditor")
        {
        }
    }
}

namespace Cengaver.Common
{
    public partial class LanguageSelectionAttribute : CustomEditorAttribute
    {
        public LanguageSelectionAttribute()
            : base("Cengaver.Common.LanguageSelection")
        {
        }
    }
}

namespace Cengaver.TvHastanesi
{
    public partial class CountyEditorAttribute : CustomEditorAttribute
    {
        public CountyEditorAttribute()
            : base("Cengaver.TvHastanesi.CountyEditor")
        {
        }
    
        public String CityEditorID
        {
            get { return GetOption<String>("cityEditorID"); }
            set { SetOption("cityEditorID", value); }
        }
    }

    public partial class CustomerEditorAttribute : CustomEditorAttribute
    {
        public CustomerEditorAttribute()
            : base("Cengaver.TvHastanesi.CustomerEditor")
        {
        }
    }
}

