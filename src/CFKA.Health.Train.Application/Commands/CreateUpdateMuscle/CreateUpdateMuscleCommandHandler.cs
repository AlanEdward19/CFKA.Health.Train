using Microsoft.Extensions.Logging;

namespace CFKA.Health.Application.Commands.CreateUpdateMuscle;

public class CreateUpdateMuscleCommandHandler : ICommandHandler
{
    private readonly IRepository<Muscle> _repository;
    private readonly ILogger<CreateUpdateMuscleCommandHandler> _logger;

    public CreateUpdateMuscleCommandHandler(IRepository<Muscle> repository, ILogger<CreateUpdateMuscleCommandHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task Insert(ICommand command)
    {
        _logger.LogInformation("Initialing insertion of new Muscle");

        var model = command as CreateUpdateMuscleCommand;
        EMuscle mainMuscle = Enum.Parse<EMuscle>(model!.MainMuscle, true);

        Muscle muscle = new()
        {
            Name = model.Name,
            MainMuscle = mainMuscle
        };

        _logger.LogInformation($"""
            Inserting new Muscle 
            With values:
                Name: {model.Name},
                MainMuscle: {mainMuscle}
            """);

        await _repository.AddAsync(muscle);

        _logger.LogInformation("Muscle inserted!");
    }

    public async Task Update(ICommand command, int id)
    {
        _logger.LogInformation($"Initialing updating of Muscle with id: {id}");

        var model = command as CreateUpdateMuscleCommand;
        EMuscle mainMuscle = Enum.Parse<EMuscle>(model!.MainMuscle, true);

        Muscle muscle = new()
        {
            Name = model.Name,
            MainMuscle = mainMuscle
        };

        _logger.LogInformation($"""
            Updating Muscle with id: {id} 
            With values:
                Name: {model.Name},
                MainMuscle: {mainMuscle}
            """);

        await _repository.UpdateAsync(muscle, id);

        _logger.LogInformation($"Muscle with id: {id} updated!");
    }

    public async Task Delete(int id)
    {
        _logger.LogInformation("Initialing deletion of new Muscle");

        _logger.LogInformation($"Deleting Muscle with id: {id}");

        await _repository.DeleteById(id);

        _logger.LogInformation($"Muscle of id: {id} deleted!");
    }
}