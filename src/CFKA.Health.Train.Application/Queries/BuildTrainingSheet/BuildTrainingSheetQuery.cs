using CFKA.Health.Train.Application.Queries.BuildTrainingExercise;
using CFKA.Health.Train.Application.Queries.BuildWorkouts;

namespace CFKA.Health.Train.Application.Queries.BuildTrainingSheet;

public class BuildTrainingSheetQuery
{
    public IEnumerable<BuildWorkoutsQuery> Workouts { get; set; }
    public DateTime ChangeDate { get; set; }
}