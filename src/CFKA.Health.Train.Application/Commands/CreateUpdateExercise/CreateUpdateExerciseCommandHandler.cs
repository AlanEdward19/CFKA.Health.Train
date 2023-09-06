using CFKA.Health.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CFKA.Health.Application.Commands.CreateUpdateExercise;

public class CreateUpdateExerciseCommandHandler : ICommandHandler
{
    private readonly IRepository<Exercise> _repository;
    private readonly ILogger<CreateUpdateExerciseCommandHandler> _logger;

    private readonly DbSet<Muscle> _muscles;

    public CreateUpdateExerciseCommandHandler(IRepository<Exercise> repository, CFKATrainDbContext dbContext, ILogger<CreateUpdateExerciseCommandHandler> logger)
    {
        _repository = repository;
        _muscles = dbContext.Muscles;
        _logger = logger;
    }

    public async Task Insert(ICommand command)
    {
        _logger.LogInformation("Initialing insertion of new Exercise");

        var model = command as CreateUpdateExerciseCommand;

        _logger.LogInformation($"Retrieving Muscle of name: {model!.Muscle}");
        Muscle muscle= await _muscles.Where(x => x.EnName.ToLower().Equals(model!.Muscle.ToLower())).FirstAsync();

        Exercise exercise = new()
        {
            EnName = model.EnName,
            PtName = model.PtName,
            MuscleId = muscle.Id
        };

        _logger.LogInformation($"""
            Inserting new Exercise 
            With values:
                Name: {model.EnName},
                MuscleName: {muscle.EnName}
            """);

        await _repository.AddAsync(exercise);

        _logger.LogInformation("Exercise inserted!");
    }

    public async Task Update(ICommand command, int id)
    {
        _logger.LogInformation($"Initialing updating of Exercise with id: {id}");

        var model = command as CreateUpdateExerciseCommand;

        _logger.LogInformation($"Retrieving Muscle of name: {model!.Muscle}");
        Muscle muscle = await _muscles.Where(x => x.EnName.ToLower().Equals(model!.Muscle.ToLower())).FirstAsync();

        Exercise exercise = new()
        {
            EnName = model.EnName,
            PtName = model.PtName,
            MuscleId = muscle.Id
        };

        _logger.LogInformation($"""
            Updating Exercise with id: {id} 
            With values:
                Name: {model.EnName},
                MuscleName: {muscle.EnName}
            """);

        await _repository.UpdateAsync(exercise, id);

        _logger.LogInformation("Exercise updated!");
    }

    public async Task Update(ICommand command, Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(int id)
    {
        _logger.LogInformation("Initialing deletion of new Muscle");

        _logger.LogInformation($"Deleting Muscle with id: {id}");

        await _repository.DeleteById(id);

        _logger.LogInformation($"Muscle of id: {id} deleted!");
    }

    public async Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}