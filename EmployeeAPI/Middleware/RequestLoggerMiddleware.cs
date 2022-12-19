using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EmployeeAPI.Middleware
{
    public class RequestLoggerMiddleware
    {
        private readonly RequestDelegate next;
        public RequestLoggerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext, ILogger<RequestLoggerMiddleware > logger )
        {
            logger.LogInformation($"Incoming Request from {nameof(RequestLoggerMiddleware)}");
            await next(httpContext);
            logger.LogInformation($"Outgoing Response from {nameof(RequestLoggerMiddleware)}");
        }
    }
}
