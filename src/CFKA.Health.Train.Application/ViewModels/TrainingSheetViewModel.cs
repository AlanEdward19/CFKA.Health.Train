namespace CFKA.Health.Train.Application.ViewModels;

public class TrainingSheetViewModel
{
    public IEnumerable<WorkoutViewModel> Workouts { get; set; }
    public DateTime ChangeDate { get; set; }
}