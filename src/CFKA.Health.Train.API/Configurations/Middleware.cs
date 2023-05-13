using CFKA.Health.Middlewares;

namespace CFKA.Health.Configurations;

public static class Middleware
{
    public static IApplicationBuilder ConfigureMiddlewares(this IApplicationBuilder app) => app.UseMiddleware<ExceptionMiddleware>();
}