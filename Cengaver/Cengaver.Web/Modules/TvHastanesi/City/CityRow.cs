
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

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__Cities"), InstanceName("TvH__Cities"), TwoLevelCached]
    [DeletePermission(PermissionKeys.Developer)]
    [ModifyPermission(PermissionKeys.Developer)]
    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("TvHastanesi.City")]
    public sealed class CityRow : Row, IIdRow, INameRow
    {
        [DisplayName("City Id"), Identity]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("City"), Size(16), QuickSearch]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CityId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.City; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CityRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field CityId;
            public readonly StringField City;

            public RowFields()
                : base("TvH__Cities")
            {
                LocalTextPrefix = "TvHastanesi.City";
            }
        }
    }
}