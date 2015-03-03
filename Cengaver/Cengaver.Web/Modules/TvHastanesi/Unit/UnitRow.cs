
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

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__Units"), InstanceName("TvH__Units"), TwoLevelCached]
    [DeletePermission(PermissionKeys.Developer)]
    [ModifyPermission(PermissionKeys.Developer)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class UnitRow : Administration.Entities.LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Unit Id"), Identity]
        public Int32? UnitId
        {
            get { return Fields.UnitId[this]; }
            set { Fields.UnitId[this] = value; }
        }

        [DisplayName("Unit"), Size(100), NotNull, QuickSearch]
        public String Unit
        {
            get { return Fields.Unit[this]; }
            set { Fields.Unit[this] = value; }
        }

        [DisplayName("Unit Type Id"), NotNull]
        public Int32? UnitTypeId
        {
            get { return Fields.UnitTypeId[this]; }
            set { Fields.UnitTypeId[this] = value; }
        }

        [DisplayName("Path"), Size(30), NotNull]
        public String Path
        {
            get { return Fields.Path[this]; }
            set { Fields.Path[this] = value; }
        }

        [DisplayName("Manager Id")]
        public Int32? ManagerId
        {
            get { return Fields.ManagerId[this]; }
            set { Fields.ManagerId[this] = value; }
        }

        [DisplayName("Firm Id")]
        public Int32? FirmId
        {
            get { return Fields.FirmId[this]; }
            set { Fields.FirmId[this] = value; }
        }

        [DisplayName("Parent Id")]
        public Int32? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.UnitId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Unit; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UnitRow()
            : base(Fields)
        {
        }

        public class RowFields : Administration.Entities.LoggingRow.LoggingRowFields
        {
            public readonly Int32Field UnitId;
            public readonly StringField Unit;
            public readonly Int32Field UnitTypeId;
            public readonly StringField Path;
            public readonly Int32Field ManagerId;
            public readonly Int32Field FirmId;
            public readonly Int32Field ParentId;

            public RowFields()
                : base("TvH__Units")
            {
                LocalTextPrefix = "TvHastanesi.Unit";
            }
        }
    }
}