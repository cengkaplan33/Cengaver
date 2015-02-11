
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
    public partial class CountyRow
    {
        public Int32? CountyId { get; set; }
        public Int32? CityId { get; set; }
        public String County { get; set; }
        public String City { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string CountyId = "CountyId";
            [InlineConstant] public const string CityId = "CityId";
            [InlineConstant] public const string County = "County";
            [InlineConstant] public const string City = "City";
        }
    }
    
}

