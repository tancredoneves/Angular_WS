using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebAPP.Models;

namespace WebAPP
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           ///inicializa o contexto toda vez que o app e inicializado
            System.Data.Entity.Database.SetInitializer(new WebApiContextInitialize());
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
