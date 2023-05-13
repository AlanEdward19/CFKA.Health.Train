using CFKA.Health.Application.Commands.CreateUpdateExercise;
using CFKA.Health.Application.Commands.CreateUpdateMuscle;
using CFKA.Health.Application.Queries.GetExercise;
using CFKA.Health.Application.Queries.GetMuscle;
using CFKA.Health.Domain.Interfaces;
using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Repository;
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

        services.AddScoped<IRepository<Muscle>, Repository<Muscle>>();
        services.AddScoped<IRepository<Exercise>, Repository<Exercise>>();

        #endregion

        return services;
    }
}