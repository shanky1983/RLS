using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Attune.KernelV2.Providers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class ValidateXsrfTokensAttribute : AuthorizationFilterAttribute
    {
        const string
            XsrfHeaderName = "X-XSRF-Field-Token",
            XsrfAjaxHeaderName = "X-XSRF-Ajax-Tokens",
            XsrfCookieName = "__XSRF-Session-Token";



        public override void OnAuthorization(HttpActionContext actionContext)
        {


            base.OnAuthorization(actionContext);
            var request = actionContext.ControllerContext.Request;

            try
            {
                //if (IsAjaxRequest(request))
                //{
                //    ValidateAjaxRequestHeader(request);
                //}
                //else
                //{
                //    ValidateRequestHeader(request);
                //}
            }
            catch (Exception ex)
            {
                actionContext.Response = request.CreateErrorResponse(HttpStatusCode.Forbidden, ex);

            }

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

        static void ValidateAjaxRequestHeader(HttpRequestMessage request)
        {
            var cookieToken = string.Empty;
            var formToken = string.Empty;

            IEnumerable<string> tokenHeaders;
            if (request.Headers.TryGetValues(XsrfAjaxHeaderName, out tokenHeaders))
            {
                var tokenValue = tokenHeaders.FirstOrDefault();
                if (!string.IsNullOrEmpty(tokenValue))
                {
                    var tokens = tokenValue.Split(':');
                    if (tokens.Length == 2)
                    {
                        cookieToken = tokens[0].Trim();
                        formToken = tokens[1].Trim();
                    }
                }
            }
            AntiForgery.Validate(cookieToken, formToken);
        }

        static void ValidateRequestHeader(HttpRequestMessage request)
        {
            var chv = request.Headers.GetCookies(XsrfCookieName).FirstOrDefault();
            var cookieToken = chv != null ? chv[XsrfCookieName].Value : null;
            IEnumerable<string> fieldTokens;
            var fieldToken = request.Headers.TryGetValues(XsrfHeaderName, out fieldTokens) ? fieldTokens.First() : null;
            AntiForgery.Validate(cookieToken, fieldToken);
        }



#endregion
    }

    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ModelState.IsValid == false)
            {
                //actionContext.Response = actionContext.Request.CreateErrorResponse(
                //    HttpStatusCode.BadRequest, actionContext.ModelState);
                var errors = new List<string>();
                foreach (var state in actionContext.ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        if(!string.IsNullOrEmpty(error.ErrorMessage))
                        errors.Add(error.ErrorMessage);
                    }
                }

                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.BadRequest, errors);
            }
        }
    }

}