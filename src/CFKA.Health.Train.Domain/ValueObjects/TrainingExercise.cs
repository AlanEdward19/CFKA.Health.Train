namespace CFKA.Health.Domain.ValueObjects;

public record TrainingExercise
{
    public Exercise Exercise { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public IEnumerable<string> Observations { get; set; }
}