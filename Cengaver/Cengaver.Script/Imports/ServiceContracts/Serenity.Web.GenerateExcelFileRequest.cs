
namespace Serenity.Web
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class GenerateExcelFileRequest : ServiceRequest
    {
        public List<String> Captions { get; set; }
        public List<List<Object>> Data { get; set; }
        public String DownloadName { get; set; }
    }
    
}

