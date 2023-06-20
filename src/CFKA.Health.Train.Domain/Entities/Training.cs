using System.ComponentModel.DataAnnotations;

namespace CFKA.Health.Domain.Entities;

public class Training
{
    [Key]
    public int Id { get; private set; }
    public string EnName { get; private set; }
    public string PtName { get; private set; }
    public string Owner { get; private set; }
    public DateTime ChangeDate { get; private set; }

    public IEnumerable<TrainingExercise> TrainingExercises { get; private set; }

    public Training(string owner, DateTime changeDate)
    {
        Owner = owner;
        ChangeDate = changeDate;
    }

    public void SetTrainingExercise(IEnumerable<TrainingExercise> trainingExercises) =>
        TrainingExercises = trainingExercises;

    public void SetTrainingName()
    {
        var enMuscles = string.Join(", ", TrainingExercises.Select(trainingExercise => trainingExercise.Exercise.Muscle.GetMainMuscleName(ELanguage.English)).Distinct());
        var enLastComma = enMuscles.LastIndexOf(",");

        var ptMuscles = string.Join(", ", TrainingExercises.Select(trainingExercise => trainingExercise.Exercise.Muscle.GetMainMuscleName(ELanguage.Portuguese)).Distinct());
        var ptLastComma = ptMuscles.LastIndexOf(",");

        EnName = enLastComma != -1 ? $"{enMuscles.Substring(0, enLastComma)} and {enMuscles.Substring(enLastComma + 1).Trim()}" : enMuscles;
        PtName = ptLastComma != -1 ? $"{ptMuscles.Substring(0, ptLastComma)} e {ptMuscles.Substring(ptLastComma + 1).Trim()}" : ptMuscles;
    }
}