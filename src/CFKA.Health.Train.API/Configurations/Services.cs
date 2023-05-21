using CFKA.Health.Domain.Interfaces;
using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Repository;
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

        #endregion

        #region Queries

        services.AddScoped<GetMuscleHandler>();
        services.AddScoped<GetExerciseHandler>();

        #endregion

        #region Repository

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        #endregion

        services.AddScoped<TrainingHandler>();

        return services;
    }
}