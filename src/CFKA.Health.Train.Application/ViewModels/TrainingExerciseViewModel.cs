namespace CFKA.Health.Train.Application.ViewModels;

public record TrainingExerciseViewModel
{
    public ExerciseViewModel Exercise { get; private set; }
    public int Sets { get; private set; }
    public int Reps { get; private set; }
    public string Observations { get; private set; }

    public TrainingExerciseViewModel(ExerciseViewModel exercise, int sets, int reps, string observations)
    {
        Exercise = exercise;
        Sets = sets;
        Reps = reps;
        Observations = observations;
    }

    public static TrainingExerciseViewModel ToEntity(TrainingExercise entity) => new(ExerciseViewModel.ToEntity(entity.Exercise), entity.Sets, entity.Reps, entity.Observations);
}