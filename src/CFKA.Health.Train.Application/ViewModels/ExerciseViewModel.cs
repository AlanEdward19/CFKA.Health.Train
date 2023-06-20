namespace CFKA.Health.Train.Application.ViewModels;

public record ExerciseViewModel
{
    public string EnName { get; private set; }
    public string PtName { get; private set; }
    public MuscleViewModel Muscle { get; private set; }

    public ExerciseViewModel(string enName, string ptName, MuscleViewModel muscle)
    {
        EnName = enName;
        PtName = ptName;
        Muscle = muscle;
    }

    public static ExerciseViewModel ToEntity(Exercise entity) =>
        new(entity.EnName, entity.PtName, MuscleViewModel.ToEntity(entity.Muscle));
}