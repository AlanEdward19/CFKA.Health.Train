namespace CFKA.Health.Train.Application.ViewModels;

public record MuscleViewModel
{
    public string MainMuscle { get; private set; }
    public string EnName { get; private set; }
    public string PtName { get; private set; }

    public MuscleViewModel(EMuscle muscle, string enName, string ptName)
    {
        MainMuscle = muscle.ToString();
        EnName = enName;
        PtName = ptName;
    }

    public static MuscleViewModel ToEntity(Muscle entity) => new(entity.MainMuscle, entity.EnName, entity.PtName);
}