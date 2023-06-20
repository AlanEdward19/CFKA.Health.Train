namespace CFKA.Health.Train.Application.ViewModels;

public record TrainingViewModel
{
    public string Owner { get; private set; }
    public string EnName { get; private set; }
    public string PtName { get; private set; }
    public DateTime ChangeDate { get; private set; }
    public IEnumerable<TrainingExerciseViewModel> TrainingExercises { get; private set; }

    public TrainingViewModel(string owner, string enName, string ptName, DateTime changeDate, IEnumerable<TrainingExerciseViewModel> trainingExercises)
    {
        Owner = owner;
        EnName = enName;
        PtName = ptName;
        ChangeDate = changeDate;
        TrainingExercises = trainingExercises;
    }

    public static TrainingViewModel ToEntity(Training entity)
    {
        var trainingExercises = (from trainingExerciseDb in entity.TrainingExercises select TrainingExerciseViewModel.ToEntity(trainingExerciseDb)).ToList();

        return new(entity.Owner, entity.EnName, entity.PtName, entity.ChangeDate, trainingExercises);
    }
}