using Microsoft.AspNetCore.Diagnostics;

namespace WebApi.Sample
{
    public class ExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = 400;
            await httpContext.Response.WriteAsync(exception.Message);

            return true;
        }
    }
}
