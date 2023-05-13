namespace CFKA.Health.Application.Commands.CreateUpdateMuscle;

public class CreateUpdateMuscleCommandHandler : ICommandHandler
{
    private readonly IRepository<Muscle> _repository;

    public CreateUpdateMuscleCommandHandler(IRepository<Muscle> repository)
    {
        _repository = repository;
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateMuscleCommand;
        EMuscle mainMuscle = Enum.Parse<EMuscle>(model!.MainMuscle, true);

        Muscle muscle = new()
        {
            Name = model.Name,
            MainMuscle = mainMuscle
        };

        await _repository.AddAsync(muscle);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateMuscleCommand;
        EMuscle mainMuscle = Enum.Parse<EMuscle>(model!.MainMuscle, true);

        Muscle muscle = new()
        {
            Name = model.Name,
            MainMuscle = mainMuscle
        };

        await _repository.UpdateAsync(muscle, id);
    }

    public async Task Delete(int id) => await _repository.DeleteById(id);
}