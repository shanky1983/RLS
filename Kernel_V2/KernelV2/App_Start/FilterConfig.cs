using System.Web.Http.Filters;

namespace Attune.KernelV2
{
    //public class FilterConfig
    //{
    //    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    //    {
    //        filters.Add(new HandleErrorAttribute());
    //    }
    //}
    public class AddCustomHeaderFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Content.Headers.Add("customHeader-1000", "custom value date time");


        }
    }
}
