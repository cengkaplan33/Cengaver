
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

    [ConnectionKey("Natro_TvHastanesi"), DisplayName("TvH__Menus"), InstanceName("TvH__Menus"), TwoLevelCached]
    [DeletePermission(PermissionKeys.Admin)]
    [ModifyPermission(PermissionKeys.Admin)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class MenuRow : Administration.Entities.LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Menu Id"), Identity]
        public Int32? MenuId
        {
            get { return Fields.MenuId[this]; }
            set { Fields.MenuId[this] = value; }
        }

        [DisplayName("Menu"), Size(250), NotNull, QuickSearch]
        public String Menu
        {
            get { return Fields.Menu[this]; }
            set { Fields.Menu[this] = value; }
        }

        [DisplayName("Display Order"), NotNull]
        public Int32? DisplayOrder
        {
            get { return Fields.DisplayOrder[this]; }
            set { Fields.DisplayOrder[this] = value; }
        }

        [DisplayName("Firm Id"), NotNull]
        public Int32? FirmId
        {
            get { return Fields.FirmId[this]; }
            set { Fields.FirmId[this] = value; }
        }

        [DisplayName("Web Site Id"), NotNull]
        public Int32? WebSiteId
        {
            get { return Fields.WebSiteId[this]; }
            set { Fields.WebSiteId[this] = value; }
        }

        [DisplayName("Path"), Size(30), NotNull]
        public String Path
        {
            get { return Fields.Path[this]; }
            set { Fields.Path[this] = value; }
        }

        [DisplayName("Url"), Size(100), NotNull]
        public String Url
        {
            get { return Fields.Url[this]; }
            set { Fields.Url[this] = value; }
        }

        [DisplayName("Parent Id")]
        public Int32? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("Root Id")]
        public Int32? RootId
        {
            get { return Fields.RootId[this]; }
            set { Fields.RootId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MenuId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Menu; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MenuRow()
            : base(Fields)
        {
        }

        public class RowFields : Administration.Entities.LoggingRow.LoggingRowFields
        {
            public readonly Int32Field MenuId;
            public readonly StringField Menu;
            public readonly Int32Field DisplayOrder;
            public readonly Int32Field FirmId;
            public readonly Int32Field WebSiteId;
            public readonly StringField Path;
            public readonly StringField Url;
            public readonly Int32Field ParentId;
            public readonly Int32Field RootId;

            public RowFields()
                : base("TvH__Menus")
            {
                LocalTextPrefix = "TvHastanesi.Menu";
            }
        }
    }
}