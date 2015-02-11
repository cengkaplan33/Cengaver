
namespace Cengaver.TvHastanesi
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class MenuRow
    {
        public Int32? MenuId { get; set; }
        public String Menu { get; set; }
        public Int32? DisplayOrder { get; set; }
        public Int32? FirmId { get; set; }
        public Int32? WebSiteId { get; set; }
        public String Path { get; set; }
        public String Url { get; set; }
        public Int32? InsertUserId { get; set; }
        public String InsertDate { get; set; }
        public Boolean? IsActive { get; set; }
        public Int32? UpdateUserId { get; set; }
        public String UpdateDate { get; set; }
        public Int32? ParentId { get; set; }
        public Int32? RootId { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string MenuId = "MenuId";
            [InlineConstant] public const string Menu = "Menu";
            [InlineConstant] public const string DisplayOrder = "DisplayOrder";
            [InlineConstant] public const string FirmId = "FirmId";
            [InlineConstant] public const string WebSiteId = "WebSiteId";
            [InlineConstant] public const string Path = "Path";
            [InlineConstant] public const string Url = "Url";
            [InlineConstant] public const string InsertUserId = "InsertUserId";
            [InlineConstant] public const string InsertDate = "InsertDate";
            [InlineConstant] public const string IsActive = "IsActive";
            [InlineConstant] public const string UpdateUserId = "UpdateUserId";
            [InlineConstant] public const string UpdateDate = "UpdateDate";
            [InlineConstant] public const string ParentId = "ParentId";
            [InlineConstant] public const string RootId = "RootId";
        }
    }
    
}

