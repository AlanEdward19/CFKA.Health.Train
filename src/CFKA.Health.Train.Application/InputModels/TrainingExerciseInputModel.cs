namespace CFKA.Health.Train.Application.InputModels;

public record TrainingExerciseInputModel
{
    public int ExerciseId { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public string Observations { get; set; }

    public static TrainingExercise ToEntity(Exercise exercise, TrainingExerciseInputModel trainingExerciseInputModel)
    {
        TrainingExercise trainingExercise = new(trainingExerciseInputModel.Sets, trainingExerciseInputModel.Reps,
            trainingExerciseInputModel.Observations);

        trainingExercise.SetExercise(exercise);

        return trainingExercise;
    }
}