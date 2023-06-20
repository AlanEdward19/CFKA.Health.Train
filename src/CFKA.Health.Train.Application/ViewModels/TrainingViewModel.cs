namespace CFKA.Health.Train.Application.ViewModels;

public record TrainingViewModel
{
    public string Owner { get; private set; }
    public string Name { get; private set; }
    public DateTime ChangeDate { get; private set; }
    public IEnumerable<TrainingExerciseViewModel> TrainingExercises { get; private set; }

    public TrainingViewModel(string owner, string name, DateTime changeDate, IEnumerable<TrainingExerciseViewModel> trainingExercises)
    {
        Owner = owner;
        Name = name;
        ChangeDate = changeDate;
        TrainingExercises = trainingExercises;
    }

    public static TrainingViewModel ToEntity(Training entity, ELanguage language)
    {
        var trainingExercises = (from trainingExerciseDb in entity.TrainingExercises
            select TrainingExerciseViewModel.ToEntity(trainingExerciseDb, language)).ToList();

        return new(entity.Owner, language == ELanguage.English ? entity.EnName : entity.PtName, entity.ChangeDate,
            trainingExercises);
    }
}