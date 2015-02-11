﻿
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
    [DeletePermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.General)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class UnitRow : Row, IIdRow, INameRow
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

        [DisplayName("Insert User Id"), NotNull]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Update User Id")]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
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

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field UnitId;
            public readonly StringField Unit;
            public readonly Int32Field UnitTypeId;
            public readonly StringField Path;
            public readonly Int32Field InsertUserId;
            public readonly DateTimeField InsertDate;
            public readonly BooleanField IsActive;
            public readonly Int32Field UpdateUserId;
            public readonly DateTimeField UpdateDate;
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