namespace CFKA.Health.Train.Application.ViewModels;

public record TrainingViewModel
{
    public int Id { get; set; }
    public Guid OwnerId { get; set; }
    public string Name { get; private set; }
    public DateTime ChangeDate { get; private set; }
    public IEnumerable<TrainingExerciseViewModel> TrainingExercises { get; private set; }

    public TrainingViewModel(int id, Guid ownerId, string name, DateTime changeDate, IEnumerable<TrainingExerciseViewModel> trainingExercises)
    {
        Id = id;
        OwnerId = ownerId;
        Name = name;
        ChangeDate = changeDate;
        TrainingExercises = trainingExercises;
    }

    public static TrainingViewModel ToEntity(Training entity, ELanguage language)
    {
        var trainingExercises = (from trainingExerciseDb in entity.TrainingExercises
            select TrainingExerciseViewModel.ToEntity(trainingExerciseDb, language)).ToList();

        return new(entity.Id, entity.OwnerId, language == ELanguage.English ? entity.EnName : entity.PtName, entity.ChangeDate,
            trainingExercises);
    }
}