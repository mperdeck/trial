using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersSample.Filters
{
    public class AddHeaderAttribute : Attribute, IResultFilter, IActionFilter, IAuthorizationFilter
    {
        private readonly string _name;
        private readonly string _value;

        public AddHeaderAttribute(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(
                _name, new string[] { _value });
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            // do something after the action executes
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // do something before the action executes
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do something after the action executes
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
        }
    }
}