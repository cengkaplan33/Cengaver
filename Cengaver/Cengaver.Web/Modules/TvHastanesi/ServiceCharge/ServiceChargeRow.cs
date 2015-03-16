
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

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__ServiceCharges"), InstanceName("TvH__ServiceCharges"), TwoLevelCached]
    [DeletePermission(PermissionKeys.ServiceRegistry)]
    [ModifyPermission(PermissionKeys.ServiceRegistry)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class ServiceChargeRow : LoggingRow, IIdRow
    {
        [DisplayName("Service Charge Id"), Identity]
        public Int32? ServiceChargeId
        {
            get { return Fields.ServiceChargeId[this]; }
            set { Fields.ServiceChargeId[this] = value; }
        }

        [DisplayName("Charge Id"), NotNull]
        public Int32? ChargeId
        {
            get { return Fields.ChargeId[this]; }
            set { Fields.ChargeId[this] = value; }
        }

        [DisplayName("Service Ticket Id"), NotNull]
        public Int32? ServiceTicketId
        {
            get { return Fields.ServiceTicketId[this]; }
            set { Fields.ServiceTicketId[this] = value; }
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

        [DisplayName("Unit Price"), Scale(4)]
        public Decimal? UnitPrice
        {
            get { return Fields.UnitPrice[this]; }
            set { Fields.UnitPrice[this] = value; }
        }

        [DisplayName("Total Tax Amount"), Scale(4)]
        public Decimal? TotalTaxAmount
        {
            get { return Fields.TotalTaxAmount[this]; }
            set { Fields.TotalTaxAmount[this] = value; }
        }

        [DisplayName("Total Amount"), Scale(4)]
        public Decimal? TotalAmount
        {
            get { return Fields.TotalAmount[this]; }
            set { Fields.TotalAmount[this] = value; }
        }

        [DisplayName("Type")]
        public Int16? Type
        {
            get { return Fields.Type[this]; }
            set { Fields.Type[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ServiceChargeId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ServiceChargeRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public readonly Int32Field ServiceChargeId;
            public readonly Int32Field ChargeId;
            public readonly Int32Field ServiceTicketId;
            public readonly Int16Field TaxRate;
            public readonly BooleanField TaxIncluded;
            public readonly DecimalField UnitPrice;
            public readonly DecimalField TotalTaxAmount;
            public readonly DecimalField TotalAmount;
            public readonly Int16Field Type;

            public RowFields()
                : base("TvH__ServiceCharges")
            {
                LocalTextPrefix = "TvHastanesi.ServiceCharge";
            }
        }
    }
}