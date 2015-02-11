
namespace Cengaver.TvHastanesi
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Cengaver.Northwind;

    public partial class CustomerForm : PrefixedContext
    {
        public CustomerForm(string idPrefix) : base(idPrefix) {}
    
        public IntegerEditor InsertUserId { get { return ById<IntegerEditor>("InsertUserId"); } }
        public DateEditor InsertDate { get { return ById<DateEditor>("InsertDate"); } }
        public BooleanEditor IsActive { get { return ById<BooleanEditor>("IsActive"); } }
        public IntegerEditor UpdateUserId { get { return ById<IntegerEditor>("UpdateUserId"); } }
        public DateEditor UpdateDate { get { return ById<DateEditor>("UpdateDate"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Surname { get { return ById<StringEditor>("Surname"); } }
        public StringEditor IdentificationNumber { get { return ById<StringEditor>("IdentificationNumber"); } }
        public StringEditor Address { get { return ById<StringEditor>("Address"); } }
        public LookupEditor CityId { get { return ById<LookupEditor>("CityId"); } }
        public LookupEditor CountyId { get { return ById<LookupEditor>("CountyId"); } }
        public StringEditor PhoneNumber { get { return ById<StringEditor>("PhoneNumber"); } }
        public StringEditor EmailAddress { get { return ById<StringEditor>("EmailAddress"); } }
    }
}

