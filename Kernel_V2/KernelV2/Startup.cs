
using System;
using Attune.KernelV2;
using Attune.KernelV2.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace Attune.KernelV2
{

    public class Startup
    {
        private static OAuthBearerAuthenticationOptions OAuthBearerOptions { get; set; }
        public void Configuration(IAppBuilder app)
        {
            
            app.UseCors(CorsOptions.AllowAll);
            ConfigureOAuth(app);
           
           
          
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            
            OAuthBearerOptions = new OAuthBearerAuthenticationOptions();

            OAuthAuthorizationServerOptions oAuthServerOptions = new OAuthAuthorizationServerOptions
            {

                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/v1/Authenticate"),

                AccessTokenExpireTimeSpan = TimeSpan.FromHours(24), //interval need to configure based on client
                Provider = new AuthorizationServerProvider(),
                RefreshTokenProvider = new RefreshTokenProvider()
                 
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(oAuthServerOptions);
            app.UseOAuthBearerAuthentication(OAuthBearerOptions);

        }
    }
}