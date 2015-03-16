using Serenity;
using Serenity.Navigation;
using Northwind = Cengaver.Northwind.Pages;
using Administration = Cengaver.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]

[assembly: NavigationMenu(8000, "Northwind", icon: "icon-anchor")]
[assembly: NavigationLink(8200, "Northwind/Customers", typeof(Northwind.CustomerController), icon: "icon-wallet")]
[assembly: NavigationLink(8300, "Northwind/Products", typeof(Northwind.ProductController), icon: "icon-present")]
[assembly: NavigationLink(8400, "Northwind/Suppliers", typeof(Northwind.SupplierController), icon: "icon-magic-wand")]
[assembly: NavigationLink(8500, "Northwind/Shippers", typeof(Northwind.ShipperController), icon: "icon-plane")]
[assembly: NavigationLink(8600, "Northwind/Categories", typeof(Northwind.CategoryController), icon: "icon-folder-alt")]
[assembly: NavigationLink(8700, "Northwind/Regions", typeof(Northwind.RegionController), icon: "icon-map")]
[assembly: NavigationLink(8800, "Northwind/Territories", typeof(Northwind.TerritoryController), icon: "icon-puzzle")]

[assembly: NavigationMenu(9000, "Administration", icon: "icon-screen-desktop")]
[assembly: NavigationLink(9100, "Administration/Languages", typeof(Administration.LanguageController), icon: "icon-bubbles")]
[assembly: NavigationLink(9200, "Administration/Translations", typeof(Administration.TranslationController), icon: "icon-speech")]
[assembly: NavigationLink(9300, "Administration/Roles", typeof(Cengaver.Administration.Pages.RoleController), icon: "icon-lock")]
[assembly: NavigationLink(9400, "Administration/User Management", typeof(Administration.UserController), icon: "icon-users")]


[assembly: NavigationMenu(2000, "TvHastanesi", icon: "icon-settings")]
[assembly: Serenity.Navigation.NavigationLink(2001, "TvHastanesi/Customer", typeof(Cengaver.TvHastanesi.Pages.CustomerController))]
[assembly: Serenity.Navigation.NavigationLink(2002, "TvHastanesi/ServiceTicket", typeof(Cengaver.TvHastanesi.Pages.ServiceTicketController))]
[assembly: Serenity.Navigation.NavigationLink(2003, "TvHastanesi/Charges", typeof(Cengaver.TvHastanesi.Pages.ChargeController))]
[assembly: Serenity.Navigation.NavigationLink(3001, "TvHastanesi/Unit", typeof(Cengaver.TvHastanesi.Pages.UnitController))]
[assembly: Serenity.Navigation.NavigationLink(3002, "TvHastanesi/City", typeof(Cengaver.TvHastanesi.Pages.CityController))]
[assembly: Serenity.Navigation.NavigationLink(3003, "TvHastanesi/County", typeof(Cengaver.TvHastanesi.Pages.CountyController))]
[assembly: Serenity.Navigation.NavigationLink(3004, "TvHastanesi/Users", typeof(Administration.UserController), Cengaver.TvHastanesi.PermissionKeys.Admin)]
[assembly: Serenity.Navigation.NavigationLink(3005, "Report", typeof(Cengaver.Common.Pages.ReportController))]





