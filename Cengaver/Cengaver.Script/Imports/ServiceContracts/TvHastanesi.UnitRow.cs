
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
    public partial class UnitRow
    {
        public Int32? UnitId { get; set; }
        public String Unit { get; set; }
        public Int32? UnitTypeId { get; set; }
        public String Path { get; set; }
        public Int32? InsertUserId { get; set; }
        public String InsertDate { get; set; }
        public Boolean? IsActive { get; set; }
        public Int32? UpdateUserId { get; set; }
        public String UpdateDate { get; set; }
        public Int32? ManagerId { get; set; }
        public Int32? FirmId { get; set; }
        public Int32? ParentId { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string UnitId = "UnitId";
            [InlineConstant] public const string Unit = "Unit";
            [InlineConstant] public const string UnitTypeId = "UnitTypeId";
            [InlineConstant] public const string Path = "Path";
            [InlineConstant] public const string InsertUserId = "InsertUserId";
            [InlineConstant] public const string InsertDate = "InsertDate";
            [InlineConstant] public const string IsActive = "IsActive";
            [InlineConstant] public const string UpdateUserId = "UpdateUserId";
            [InlineConstant] public const string UpdateDate = "UpdateDate";
            [InlineConstant] public const string ManagerId = "ManagerId";
            [InlineConstant] public const string FirmId = "FirmId";
            [InlineConstant] public const string ParentId = "ParentId";
        }
    }
    
}

