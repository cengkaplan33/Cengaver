
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
    public partial class ChargeRow
    {
        public Int32? ChargeId { get; set; }
        public String Charge { get; set; }
        public String Code { get; set; }
        public Int16? TaxRate { get; set; }
        public Boolean? TaxIncluded { get; set; }
        public Decimal? Price { get; set; }
        public Int16? Type { get; set; }
        public Int32? InsertUserId { get; set; }
        public String InsertDate { get; set; }
        public Int32? UpdateUserId { get; set; }
        public String UpdateDate { get; set; }
        public Int16? IsActive { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string ChargeId = "ChargeId";
            [InlineConstant] public const string Charge = "Charge";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string TaxRate = "TaxRate";
            [InlineConstant] public const string TaxIncluded = "TaxIncluded";
            [InlineConstant] public const string Price = "Price";
            [InlineConstant] public const string Type = "Type";
            [InlineConstant] public const string InsertUserId = "InsertUserId";
            [InlineConstant] public const string InsertDate = "InsertDate";
            [InlineConstant] public const string UpdateUserId = "UpdateUserId";
            [InlineConstant] public const string UpdateDate = "UpdateDate";
            [InlineConstant] public const string IsActive = "IsActive";
        }
    }
    
}

