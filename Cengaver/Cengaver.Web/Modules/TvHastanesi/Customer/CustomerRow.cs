
namespace Cengaver.TvHastanesi.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__Customers"), InstanceName("TvH__Customers"), TwoLevelCached]
    [DeletePermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.General)]
    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("TvHastanesi.Customer")]
    public sealed class CustomerRow : Administration.Entities.LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Customer Id"), Identity]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Name"), Size(15), QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Surname"), Size(15)]
        public String Surname
        {
            get { return Fields.Surname[this]; }
            set { Fields.Surname[this] = value; }
        }

        [DisplayName("Identification Number"), Size(11)]
        public String IdentificationNumber
        {
            get { return Fields.IdentificationNumber[this]; }
            set { Fields.IdentificationNumber[this] = value; }
        }

        [DisplayName("Address"), Size(200)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("City Id"), ForeignKey("TvH__Cities", "CityId"), LeftJoin("jCity")]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("County Id"), ForeignKey("TvH__Counties", "CountyId"), LeftJoin("jCounty")]
        public Int32? CountyId
        {
            get { return Fields.CountyId[this]; }
            set { Fields.CountyId[this] = value; }
        }

        [DisplayName("Phone Number"), Size(13)]
        public String PhoneNumber
        {
            get { return Fields.PhoneNumber[this]; }
            set { Fields.PhoneNumber[this] = value; }
        }

        [DisplayName("Email Address"), Size(50)]
        public String EmailAddress
        {
            get { return Fields.EmailAddress[this]; }
            set { Fields.EmailAddress[this] = value; }
        }

        [DisplayName("City"), Expression("jCity.City")]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        [DisplayName("County City Id"), Expression("jCounty.CityId")]
        public Int32? CountyCityId
        {
            get { return Fields.CountyCityId[this]; }
            set { Fields.CountyCityId[this] = value; }
        }

        [DisplayName("County"), Expression("jCounty.County")]
        public String County
        {
            get { return Fields.County[this]; }
            set { Fields.County[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CustomerId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomerRow()
            : base(Fields)
        {
        }

        public class RowFields : Administration.Entities.LoggingRow.LoggingRowFields
        {
            public readonly Int32Field CustomerId;
            public readonly StringField Name;
            public readonly StringField Surname;
            public readonly StringField IdentificationNumber;
            public readonly StringField Address;
            public readonly Int32Field CityId;
            public readonly Int32Field CountyId;
            public readonly StringField PhoneNumber;
            public readonly StringField EmailAddress;

            public readonly StringField City;


            public readonly Int32Field CountyCityId;
            public readonly StringField County;


            public RowFields()
                : base("TvH__Customers")
            {
                LocalTextPrefix = "TvHastanesi.Customer";
            }
        }
    }
}