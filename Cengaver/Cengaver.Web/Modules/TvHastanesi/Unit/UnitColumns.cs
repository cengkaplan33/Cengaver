
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.Unit")]
    [BasedOnRow(typeof(Entities.UnitRow))]
    public class UnitColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 UnitId { get; set; }
        [EditLink]
        public String Unit { get; set; }
        public Int32 UnitTypeId { get; set; }
        public String Path { get; set; }
        public Int32 ManagerId { get; set; }
        public Int32 FirmId { get; set; }
        public Int32 ParentId { get; set; }
    }
}