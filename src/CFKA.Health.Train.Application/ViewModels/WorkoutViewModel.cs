namespace CFKA.Health.Train.Application.ViewModels;

public class WorkoutViewModel
{
    public string Name { get; set; }
    public IEnumerable<TrainingExerciseViewModel> Exercises { get; set; }

    public WorkoutViewModel(IEnumerable<TrainingExerciseViewModel> exercises)
    {
        Exercises = exercises;

        SetTrainingName();
    }

    public void SetTrainingName()
    {
        var muscles = string.Join(",", Exercises.Select(exercise => exercise.MainMuscle).ToList().Distinct());
        var lastComma = muscles.LastIndexOf(",");

        Name = lastComma != -1 ? $"{muscles.Substring(0, lastComma)} and {muscles.Substring(lastComma + 1)}" : muscles;
    }
}