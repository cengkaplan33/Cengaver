
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

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__Counties"), InstanceName("TvH__Counties"), TwoLevelCached]
    [DeletePermission(PermissionKeys.Developer)]
    [ModifyPermission(PermissionKeys.Developer)]
    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("TvHastanesi.County")]

    public sealed class CountyRow : Row, IIdRow, INameRow
    {
        [DisplayName("County Id"), Identity]
        public Int32? CountyId
        {
            get { return Fields.CountyId[this]; }
            set { Fields.CountyId[this] = value; }
        }

        [DisplayName("City Id"), NotNull, ForeignKey("TvH__Cities", "CityId"), LeftJoin("jCity"), LookupInclude]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("County"), Size(20), QuickSearch]
        public String County
        {
            get { return Fields.County[this]; }
            set { Fields.County[this] = value; }
        }

        [DisplayName("City"), Expression("jCity.City")]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CountyId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.County; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CountyRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field CountyId;
            public readonly Int32Field CityId;
            public readonly StringField County;

            public readonly StringField City;


            public RowFields()
                : base("TvH__Counties")
            {
                LocalTextPrefix = "TvHastanesi.County";
            }
        }
    }
}