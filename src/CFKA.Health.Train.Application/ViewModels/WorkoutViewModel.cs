namespace CFKA.Health.Train.Application.ViewModels;

public class WorkoutViewModel
{
    public string Name { get; set; }
    public IEnumerable<TrainingExerciseViewModel> Exercises { get; set; }

    public WorkoutViewModel(IEnumerable<TrainingExerciseViewModel> exercises, ELanguage language)
    {
        Exercises = exercises;

        SetTrainingName(language);
    }

    public void SetTrainingName(ELanguage language)
    {
        var muscles = string.Join(", ", Exercises.Select(exercise => exercise.MainMuscle).ToList().Distinct());
      
        var lastComma = muscles.LastIndexOf(",");
        string concatenation = language switch
        {
            ELanguage.English => "and",
            ELanguage.Portuguese => "e"
        };

        Name = lastComma != -1 ? $"{muscles.Substring(0, lastComma)} {concatenation} {muscles.Substring(lastComma + 1)}" : muscles;
    }

}