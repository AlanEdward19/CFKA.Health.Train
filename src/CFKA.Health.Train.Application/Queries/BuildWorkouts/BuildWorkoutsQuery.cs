using CFKA.Health.Train.Application.Queries.BuildTrainingExercise;

namespace CFKA.Health.Train.Application.Queries.BuildWorkouts;

public class BuildWorkoutsQuery
{
    public IEnumerable<BuildTrainingExerciseQuery> TrainingExercises { get; set; }
}