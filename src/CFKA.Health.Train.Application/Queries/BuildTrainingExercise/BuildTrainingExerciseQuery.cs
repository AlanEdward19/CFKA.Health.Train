namespace CFKA.Health.Train.Application.Queries.BuildTrainingExercise;

public class BuildTrainingExerciseQuery
{
    public string Exercise { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public IEnumerable<string> Observations { get; set; }
}