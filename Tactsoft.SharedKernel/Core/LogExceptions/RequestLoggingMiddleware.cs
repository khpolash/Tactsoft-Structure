using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Tactsoft.SharedKernel.Core.LogExceptions;
public class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

    public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();

        try
        {
            // Log request details
            _logger.LogInformation("Handling request: {Method} {Url}", context.Request.Method, context.Request.Path);

            await _next(context);

            // Log response details
            _logger.LogInformation("Handled request: {Method} {Url} - {StatusCode} in {ElapsedMilliseconds}ms",
                context.Request.Method, context.Request.Path, context.Response.StatusCode, stopwatch.ElapsedMilliseconds);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error handling request: {Method} {Url}", context.Request.Method, context.Request.Path);
            throw;
        }
        finally
        {
            stopwatch.Stop();
        }
    }
}
