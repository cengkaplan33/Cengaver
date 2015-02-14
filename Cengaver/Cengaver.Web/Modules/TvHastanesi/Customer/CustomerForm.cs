
namespace Cengaver.TvHastanesi.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("TvHastanesi.Customer")]
    [BasedOnRow(typeof(Entities.CustomerRow))]
    public class CustomerForm
    {
        public String Name { get; set; }
        public String Surname { get; set; }

        [NumberFormatter]
        public String IdentificationNumber { get; set; }
    
        [TextAreaEditor]
        public String Address { get; set; }

        [LookupEditor(typeof(Entities.CityRow))]
        public Int32 CityId { get; set; }

        [CountyEditor(CityEditorID = "CityId")]
        public Int32 CountyId { get; set; }

        [PhoneEditor]
        public String PhoneNumber { get; set; }

        //[EmailEditor]
        public String EmailAddress { get; set; }


        //public Int32 InsertUserId { get; set; }
        //public DateTime InsertDate { get; set; }
        //public Boolean IsActive { get; set; }
        //public Int32 UpdateUserId { get; set; }
        //public DateTime UpdateDate { get; set; }
    }
}