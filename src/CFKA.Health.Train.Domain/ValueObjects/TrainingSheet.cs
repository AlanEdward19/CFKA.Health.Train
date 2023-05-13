namespace CFKA.Health.Domain.ValueObjects;

public record TrainingSheet
{
    public IEnumerable<Workout> Workouts { get; set; }
    public DateTime ChangeDate { get; set; }
}