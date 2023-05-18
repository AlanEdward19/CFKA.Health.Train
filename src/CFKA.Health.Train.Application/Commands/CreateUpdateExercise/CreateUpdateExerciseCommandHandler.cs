using CFKA.Health.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Application.Commands.CreateUpdateExercise;

public class CreateUpdateExerciseCommandHandler : ICommandHandler
{
    private readonly IRepository<Exercise> _repository;
    private readonly DbSet<Muscle> _muscles;

    public CreateUpdateExerciseCommandHandler(IRepository<Exercise> repository, CFKATrainDbContext dbContext)
    {
        _repository = repository;
        _muscles = dbContext.Muscles;
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateExerciseCommand;
        Muscle muscle= await _muscles.Where(x => x.Name.ToLower().Equals(model!.Muscle.ToLower())).FirstAsync();

        Exercise exercise = new()
        {
            Name = model.Name,
            MuscleId = muscle.Id
        };

        await _repository.AddAsync(exercise);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateExerciseCommand;
        Muscle muscle = await _muscles.Where(x => x.Name.ToLower().Equals(model!.Muscle.ToLower())).FirstAsync();

        Exercise exercise = new()
        {
            Name = model.Name,
            MuscleId = muscle.Id
        };

        await _repository.UpdateAsync(exercise, id);
    }

    public async Task Delete(int id) => await _repository.DeleteById(id);
}