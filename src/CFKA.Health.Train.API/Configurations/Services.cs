using CFKA.Health.Domain.Interfaces;
using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Repository;
using CFKA.Health.Train.Application.Commands.CreateUpdateTraining;
using CFKA.Health.Train.Application.Handler;
using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Configurations;

public static class Services
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CFKATrainDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Database")));

        #region Commands

        services.AddScoped<CreateUpdateMuscleCommandHandler>();
        services.AddScoped<CreateUpdateExerciseCommandHandler>();
        services.AddScoped<CreateUpdateUserCommandHandler>();

        #endregion

        #region Queries

        services.AddScoped<GetMuscleHandler>();
        services.AddScoped<GetExerciseHandler>();
        services.AddScoped<GetUserHandler>();

        #endregion

        #region Repository

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        #endregion

        #region CORS

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });

        #endregion

        services.AddScoped<TrainingHandler>();

        return services;
    }
}