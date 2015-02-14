
namespace Cengaver.TvHastanesi
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Cengaver.TvHastanesi;
    using Cengaver.Northwind;

    public partial class CustomerForm : PrefixedContext
    {
        public CustomerForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Surname { get { return ById<StringEditor>("Surname"); } }
        public StringEditor IdentificationNumber { get { return ById<StringEditor>("IdentificationNumber"); } }
        public TextAreaEditor Address { get { return ById<TextAreaEditor>("Address"); } }
        public LookupEditor CityId { get { return ById<LookupEditor>("CityId"); } }
        public CountyEditor CountyId { get { return ById<CountyEditor>("CountyId"); } }
        public Serenity.PhoneEditor PhoneNumber { get { return ById<Serenity.PhoneEditor>("PhoneNumber"); } }
        public EmailEditor EmailAddress { get { return ById<EmailEditor>("EmailAddress"); } }
    }
}

