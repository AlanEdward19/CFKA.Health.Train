namespace CFKA.Health.Application.Commands.CreateUpdateExercise;

public class CreateUpdateExerciseCommand : ICommand
{
    public string EnName { get; set; }
    public string PtName { get; set; }
    public string Muscle { get; set; }
}