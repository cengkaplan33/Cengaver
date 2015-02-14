
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("TvHastanesi.Customer")]
    [BasedOnRow(typeof(Entities.CustomerRow))]
    public class CustomerColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CustomerId { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String Surname { get; set; }
        public String IdentificationNumber { get; set; }
        public String Address { get; set; }

        [EditLink(ItemType = "TvHastanesi.City", IdField = "CityId"), Width(150)]
        public Int32 CityId { get; set; }

        [EditLink(ItemType = "TvHastanesi.County", IdField = "CountyId"), Width(150)]
        public Int32 CountyId { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAddress { get; set; }


        //public Int32 InsertUserId { get; set; }
        //public DateTime InsertDate { get; set; }
        //public Boolean IsActive { get; set; }
        //public Int32 UpdateUserId { get; set; }
        //public DateTime UpdateDate { get; set; }
    }
}