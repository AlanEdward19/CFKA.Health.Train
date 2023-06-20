using CFKA.Health.Train.Application.InputModels;

namespace CFKA.Health.Train.Application.Commands.CreateUpdateTraining;

public class CreateUpdateTrainingCommand : ICommand
{
    public DateTime ChangeDate { get; set; }
    public IEnumerable<TrainingExerciseInputModel> TrainingExercises { get; set; }
}