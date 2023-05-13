namespace CFKA.Health.Application.Commands.CreateUpdateExercise;

public class CreateUpdateExerciseCommand : ICommand
{
    public string Name { get; set; }
    public string Muscle { get; set; }
}