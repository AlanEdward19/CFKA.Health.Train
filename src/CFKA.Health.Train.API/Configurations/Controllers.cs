using System.Text.Json.Serialization;
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

        services.AddControllersWithViews()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            });

        return services;
    }
}