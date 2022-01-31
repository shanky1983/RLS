using Attune.KernelV2;
//using LIMSAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace LIMSAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ConfigMessageHandlers(GlobalConfiguration.Configuration);
            
        }
        static void ConfigMessageHandlers(HttpConfiguration config)
        {
            var xh = new XsrfHandler();
            config.MessageHandlers.Add(xh);
        }
    }
}
