using eProject.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AccountMiddleware
    {
        private readonly RequestDelegate _next;

        public AccountMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;
            if (path.HasValue && path.Value.StartsWith("/admin"))
            {
                if (httpContext.Session.GetString("username") == null)
                {
                    httpContext.Response.Redirect("/account/login");
                }
            }
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AccountMiddlewareExtensions
    {
        public static IApplicationBuilder UseAccountMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AccountMiddleware>();
        }
    }
}
