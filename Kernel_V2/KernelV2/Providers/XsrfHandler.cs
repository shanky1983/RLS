using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;

namespace Attune.KernelV2.Providers
{
    public class XsrfHandler : DelegatingHandler
    {
        const string
            XsrfFieldTokenHeaderName = "X-XSRF-Field-Token",
            XsrfSessionTokenHeaderName = "X-XSRF-Session-Token",
            XsrfSessionTokenCookieName = "__XSRF-Session-Token";

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            var chv = request.Headers.GetCookies(XsrfSessionTokenCookieName).FirstOrDefault();
            var oldCookieToken = chv != null ? chv[XsrfSessionTokenCookieName].Value : null;

            //AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Name;
            //string newCookieToken;
            //string fieldToken;
            //AntiForgery.GetTokens(oldCookieToken, out newCookieToken, out fieldToken);

            //if (newCookieToken != null)
            //{
            //    var cookie = new CookieHeaderValue(XsrfSessionTokenCookieName, newCookieToken)
            //    {
            //        Expires = DateTimeOffset.Now.AddDays(1),
            //        Domain = request.RequestUri.Host,
            //        Path = "/",
            //        HttpOnly = true
            //    };
            //    response.Headers.AddCookies(new[] { cookie });
            //}

            //response.Headers.Add(XsrfFieldTokenHeaderName, fieldToken);
            //if (IsAjaxRequest(request))
            //{
            //    response.Headers.Add(XsrfSessionTokenHeaderName, newCookieToken ?? oldCookieToken);
            //}

            if (request.Headers.Contains("IsWrapReq"))
            {
                return BuildApiResponse(request, response);
            }


            return response;
        }
        private static HttpResponseMessage BuildApiResponse(HttpRequestMessage request, HttpResponseMessage response)
        {
            object content;


            if (response.TryGetContentValue(out content) && !response.IsSuccessStatusCode)
            {
                HttpError error = content as HttpError;

                if (error != null)
                {
                    content = error.Message;

				}
            }

            var newResponse = request.CreateResponse(response.StatusCode, new ApiResponse(response.StatusCode, content));

            foreach (var header in response.Headers)
            {
                newResponse.Headers.Add(header.Key, header.Value);
            }

            return newResponse;
        }


        #region Helpers

        static bool IsAjaxRequest(HttpRequestMessage request)
        {
            IEnumerable<string> xRequestedWithHeaders;
            if (!request.Headers.TryGetValues("X-Requested-With", out xRequestedWithHeaders))
                return false;

            var headerValue = xRequestedWithHeaders.FirstOrDefault();
            return !string.IsNullOrEmpty(headerValue) && string.Equals(headerValue, "XMLHttpRequest", StringComparison.OrdinalIgnoreCase);
        }

        #endregion
    }
}