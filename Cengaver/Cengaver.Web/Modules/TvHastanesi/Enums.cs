
using Serenity.ComponentModel;
using System.ComponentModel;

namespace Cengaver.TvHastanesi.Enums
{
    [ScriptInclude]
    //[EnumKey("PaymentType")]
    public enum PaymentType
    {
        [Description("Nakit")]
        Cash = 1,
        [Description("Kredi Kartı")]
        CreditCard = 2,
        [Description("Havale")]
        Transfer = 3,
        [Description("Çek")]
        Check = 4,
        [Description("Senet")]
        Voucher = 5
    }

    [ScriptInclude]
    public enum ServiceTicketFormType
    {
        Registation = 10,
        RegistationUser = 11,
        RegistrationTechnician = 14,
        Sony = 20,
    }

    [ScriptInclude]
    public enum ServiceTicketOperationType
    {
        [Description("Tamir")]
        Repair = 1,
        [Description("Değişim")]
        Change = 2,
        [Description("Geri Alma")]
        Return = 3,
    }

    [ScriptInclude]
    public enum ServiceTicketStageType
    {
        [Description("Serviste")]
        Service = 1,
        [Description("Müşteride")]
        Customer = 2,
        [Description("Tamirde")]
        Workshop = 3,
    }
}