using EmployeeAPI.Middleware;
using Microsoft.AspNetCore.Builder;

namespace EmployeeAPI.Extension
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestLogger(this IApplicationBuilder applicationBuilder )
        {
            return applicationBuilder.UseMiddleware<RequestLoggerMiddleware >();
        }
    }
}
