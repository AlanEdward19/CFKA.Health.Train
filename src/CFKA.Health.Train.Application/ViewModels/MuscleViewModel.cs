namespace CFKA.Health.Train.Application.ViewModels;

public record MuscleViewModel
{
    public string MainMuscle { get; private set; }
    public string Name { get; private set; }

    public MuscleViewModel(string mainMuscle, string name)
    {
        MainMuscle = mainMuscle;
        Name = name;
    }

    public static MuscleViewModel ToEntity(Muscle entity, ELanguage language) => new(entity.GetMainMuscleName(language),
        language == ELanguage.English ? entity.EnName : entity.PtName);
}