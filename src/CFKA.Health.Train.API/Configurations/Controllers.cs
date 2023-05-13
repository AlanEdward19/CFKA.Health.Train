using CFKA.Health.Filters;

namespace CFKA.Health.Configurations;

public static class Controllers
{
    public static IServiceCollection ConfigureController(this IServiceCollection services)
    {
        services
            .AddControllers(options =>
            {
                options.Filters.Add<ValidationFilter>();
            });

        return services;
    }
}