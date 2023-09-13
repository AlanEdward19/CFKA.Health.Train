using System.Text.Json.Serialization;
using CFKA.Health.Filters;
using CFKA.Health.Train.Application.Validators.Training;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace CFKA.Health.Configurations;

public static class Controllers
{
    public static IServiceCollection ConfigureController(this IServiceCollection services)
    {
        services
            .AddControllers(options =>
            {
                options.Filters.Add<ValidationFilter>();
            })
            .AddFluentValidation(c =>
            {
                c.RegisterValidatorsFromAssemblyContaining<TrainingValidator>();
                c.ValidatorOptions.DefaultClassLevelCascadeMode = CascadeMode.Stop;
            });

        services.AddControllersWithViews()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            });

        return services;
    }
}