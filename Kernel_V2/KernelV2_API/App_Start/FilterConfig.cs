using System.Web.Mvc;

namespace Attune.KernelV2.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
    //public class AddCustomHeaderFilter : System.Web.Http.Filters.ActionFilterAttribute
    //{
    //    public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
    //    {
    //        actionExecutedContext.Response.Content.Headers.Add("customHeader-1000", "custom value date time");


    //    }
    //}
}
