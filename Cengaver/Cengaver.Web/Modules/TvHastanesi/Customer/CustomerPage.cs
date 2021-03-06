﻿namespace Cengaver.TvHastanesi.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("TvHastanesi/Customer"), Route("{action=index}")]
    public class CustomerController : Controller
    {
        [PageAuthorize(PermissionKeys.ServiceRegistry)]
        public ActionResult Index()
        {
            return View("~/Modules/TvHastanesi/Customer/CustomerIndex.cshtml");
        }
    }
}