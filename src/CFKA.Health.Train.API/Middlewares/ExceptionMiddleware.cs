using System.Net;
using System.Text.Json;

namespace CFKA.Health.Middlewares;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            #region Status Code

            switch (error)
            {
                case KeyNotFoundException e:
                    // not found error
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    _logger.LogWarning($"[Resource not found request] {error.Message}");
                    break;

                case UnauthorizedAccessException e:
                    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    _logger.LogWarning($"[Unauthorized request] {error.Message}");
                    break;

                default:
                    // unhandled error
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    _logger.LogError($"[Internal error request] {error.Message}");
                    break;
            }

            #endregion

            #region Build Error Message

            var result = JsonSerializer.Serialize(new
            {
                type = error.GetType().ToString(),
                title = error.GetType().Name,
                status = response.StatusCode,
                error = error.Message,
                occuredAt = DateTime.UtcNow
            });

            #endregion

            await response.WriteAsync(result);

        }
    }
}
