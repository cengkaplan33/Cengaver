
namespace Cengaver.TvHastanesi.Entities
{
    using Cengaver.Administration.Entities;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__Charges"), InstanceName("TvH__Charges"), TwoLevelCached]
    [DeletePermission(PermissionKeys.ServiceRegistry)]
    [ModifyPermission(PermissionKeys.ServiceRegistry)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class ChargeRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Charge Id"), Identity]
        public Int32? ChargeId
        {
            get { return Fields.ChargeId[this]; }
            set { Fields.ChargeId[this] = value; }
        }

        [DisplayName("Charge"), Size(30), QuickSearch]
        public String Charge
        {
            get { return Fields.Charge[this]; }
            set { Fields.Charge[this] = value; }
        }

        [DisplayName("Code"), Size(14)]
        public String Code
        {
            get { return Fields.Code[this]; }
            set { Fields.Code[this] = value; }
        }

        [DisplayName("Tax Rate")]
        public Int16? TaxRate
        {
            get { return Fields.TaxRate[this]; }
            set { Fields.TaxRate[this] = value; }
        }

        [DisplayName("Tax Included")]
        public Boolean? TaxIncluded
        {
            get { return Fields.TaxIncluded[this]; }
            set { Fields.TaxIncluded[this] = value; }
        }

        [DisplayName("Price"), Scale(4)]
        public Decimal? Price
        {
            get { return Fields.Price[this]; }
            set { Fields.Price[this] = value; }
        }

        [DisplayName("Type")]
        public Int16? Type
        {
            get { return Fields.Type[this]; }
            set { Fields.Type[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ChargeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Charge; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ChargeRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public readonly Int32Field ChargeId;
            public readonly StringField Charge;
            public readonly StringField Code;
            public readonly Int16Field TaxRate;
            public readonly BooleanField TaxIncluded;
            public readonly DecimalField Price;
            public readonly Int16Field Type;

            public RowFields()
                : base("TvH__Charges")
            {
                LocalTextPrefix = "TvHastanesi.Charge";
            }
        }
    }
}