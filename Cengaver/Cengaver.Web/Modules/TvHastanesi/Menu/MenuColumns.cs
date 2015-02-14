
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.Menu")]
    [BasedOnRow(typeof(Entities.MenuRow))]
    public class MenuColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MenuId { get; set; }
        [EditLink]
        public String Menu { get; set; }
        public Int32 DisplayOrder { get; set; }
        public Int32 FirmId { get; set; }
        public Int32 WebSiteId { get; set; }
        public String Path { get; set; }
        public String Url { get; set; }
        public Int32 ParentId { get; set; }
        public Int32 RootId { get; set; }

        //public Int32 InsertUserId { get; set; }
        //public DateTime InsertDate { get; set; }
        //public Boolean IsActive { get; set; }
        //public Int32 UpdateUserId { get; set; }
        //public DateTime UpdateDate { get; set; }
    }
}