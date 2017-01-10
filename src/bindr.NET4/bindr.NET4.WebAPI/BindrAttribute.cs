using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace bindr.NET4.WebAPI
{
    public class BindrAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            throw new NotImplementedException();
        }
    }
}
