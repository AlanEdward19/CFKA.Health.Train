namespace CFKA.Health.Train.Application.ViewModels;

public record TrainingExerciseViewModel
{
    public string Name { get; set; }
    public string Muscle { get; set; }
    public string MainMuscle { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public IEnumerable<string> Observations { get; set; }
}