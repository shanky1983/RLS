using System;
using System.Net.Http.Extensions.Compression.Core.Compressors;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Attune.KernelV2.Providers;
using Microsoft.AspNet.WebApi.Extensions.Compression.Server;

namespace Attune.KernelV2.API
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
           
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configuration.MessageHandlers.Insert(0, new ServerCompressionHandler(new GZipCompressor(), new DeflateCompressor()));
            ConfigMessageHandlers(GlobalConfiguration.Configuration);
            

        }
        static void ConfigMessageHandlers(HttpConfiguration config)
        {
            var xh = new XsrfHandler();
            config.MessageHandlers.Add(xh);
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
        }
    }
}