
namespace Cengaver.TvHastanesi.Enums
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [EnumKey("Cengaver.TvHastanesi.Enums.PaymentType"), PreserveMemberCase]
    public enum PaymentType
    {
        Cash = 1,
        CreditCard = 2,
        Transfer = 3,
        Check = 4,
        Voucher = 5
    }
    
}

