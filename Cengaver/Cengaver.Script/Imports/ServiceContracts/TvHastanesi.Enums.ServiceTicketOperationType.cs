
namespace Cengaver.TvHastanesi.Enums
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [EnumKey("Cengaver.TvHastanesi.Enums.ServiceTicketOperationType"), PreserveMemberCase]
    public enum ServiceTicketOperationType
    {
        Repair = 1,
        Change = 2,
        Return = 3
    }
    
}

