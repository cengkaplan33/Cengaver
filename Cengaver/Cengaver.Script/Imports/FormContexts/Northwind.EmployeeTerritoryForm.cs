
namespace Cengaver.Northwind
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Cengaver.Northwind;

    public partial class EmployeeTerritoryForm : PrefixedContext
    {
        public EmployeeTerritoryForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor TerritoryID { get { return ById<StringEditor>("TerritoryID"); } }
    }
}

