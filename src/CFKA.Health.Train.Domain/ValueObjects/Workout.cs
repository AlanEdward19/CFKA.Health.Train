namespace CFKA.Health.Domain.ValueObjects;

public record Workout
{
    public string Name;
    public IEnumerable<TrainingExercise> Exercises { get; set; }

    public Workout(IEnumerable<TrainingExercise> exercises)
    {
        Exercises = exercises;

        SetTrainingName();
    }

    public void SetTrainingName()
    {
        var muscles = string.Join(",", Exercises.Select(exercise => exercise.Exercise.Muscle.MainMuscle.ToString()).ToList());
        var lastComma = muscles.LastIndexOf(",");

        Name = $"{muscles.Substring(0, lastComma)} and {muscles.Substring(lastComma + 1)}";
    }
}