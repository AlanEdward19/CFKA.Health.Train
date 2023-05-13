namespace CFKA.Health.Domain.ValueObjects;

public record Workout
{
    public string Name;
    public IEnumerable<Exercise> Exercises { get; set; }

    public Workout(IEnumerable<Exercise> exercises)
    {
        Exercises = exercises;

        SetTrainingName();
    }

    public void SetTrainingName()
    {
        var muscles = string.Join(",", Exercises.Select(exercise => exercise.Muscle.MainMuscle.ToString()).ToList());
        var lastComma = muscles.LastIndexOf(",");

        Name = $"{muscles.Substring(0, lastComma)} e {muscles.Substring(lastComma + 1)}";
    }
}