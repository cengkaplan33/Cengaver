
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
    public partial class CustomerRow
    {
        public Int32? CustomerId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String IdentificationNumber { get; set; }
        public String Address { get; set; }
        public Int32? CityId { get; set; }
        public Int32? CountyId { get; set; }
        public String MobileNumber { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAddress { get; set; }
        public String City { get; set; }
        public Int32? CountyCityId { get; set; }
        public String County { get; set; }
        public Int32? InsertUserId { get; set; }
        public String InsertDate { get; set; }
        public Int32? UpdateUserId { get; set; }
        public String UpdateDate { get; set; }
        public Int16? IsActive { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string CustomerId = "CustomerId";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Surname = "Surname";
            [InlineConstant] public const string IdentificationNumber = "IdentificationNumber";
            [InlineConstant] public const string Address = "Address";
            [InlineConstant] public const string CityId = "CityId";
            [InlineConstant] public const string CountyId = "CountyId";
            [InlineConstant] public const string MobileNumber = "MobileNumber";
            [InlineConstant] public const string PhoneNumber = "PhoneNumber";
            [InlineConstant] public const string EmailAddress = "EmailAddress";
            [InlineConstant] public const string City = "City";
            [InlineConstant] public const string CountyCityId = "CountyCityId";
            [InlineConstant] public const string County = "County";
            [InlineConstant] public const string InsertUserId = "InsertUserId";
            [InlineConstant] public const string InsertDate = "InsertDate";
            [InlineConstant] public const string UpdateUserId = "UpdateUserId";
            [InlineConstant] public const string UpdateDate = "UpdateDate";
            [InlineConstant] public const string IsActive = "IsActive";
        }
    }
    
}

