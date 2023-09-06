namespace CFKA.Health.Application.Commands.CreateUpdateMuscle;

public class CreateUpdateMuscleCommand : ICommand
{
    [EnumValidator(EnumType = typeof(EMuscle))]
    public string MainMuscle { get; set; }
    public string EnName { get; set; }
    public string PtName { get; set; }
}