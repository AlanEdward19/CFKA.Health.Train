using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Extensions;
using CFKA.Health.Train.Application.Queries.BuildTrainingSheet;
using CFKA.Health.Train.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CFKA.Health.Train.Application.Handler;

public class TrainingHandler
{
    private readonly DbSet<Exercise> _exercises;
    private readonly ILogger<TrainingHandler> _logger;

    public TrainingHandler(CFKATrainDbContext dbContext, ILogger<TrainingHandler> logger)
    {
        _exercises = dbContext.Set<Exercise>();
        _logger = logger;
    }

    public async Task<TrainingSheetViewModel> BuildTrainingSheet(BuildTrainingSheetQuery query)
    {
        _logger.LogInformation("Initializing trainingSheet build");

        var queryWorkoutList = query.Workouts.SelectMany(x => x.TrainingExercises.Select(y => y.Exercise.ToLower()))
            .ToList();

        _logger.LogInformation("Retrieving exercises by name");
        var exercises = await _exercises.VirtualInclude().Where(exercise =>
            queryWorkoutList.Contains(query.Language == ELanguage.English
                ? exercise.EnName.ToLower()
                : exercise.PtName.ToLower())).ToListAsync();
        _logger.LogInformation("Exercises retrieved");

        _logger.LogInformation("Building workout");

        var workouts = BuildWorkouts(query, exercises);

        _logger.LogInformation($"Workout built, with changeDate defined to: {query.ChangeDate}");

        var trainingSheet = new TrainingSheetViewModel
        {
            Workouts = workouts,
            ChangeDate = query.ChangeDate
        };

        return trainingSheet;
    }

    private List<WorkoutViewModel> BuildWorkouts(BuildTrainingSheetQuery query, List<Exercise> exercises)
    {
        var workouts = new List<WorkoutViewModel>();

        foreach (var workout in query.Workouts)
        {
            var trainingExercises = new List<TrainingExerciseViewModel>();

            foreach (var trainingExercise in workout.TrainingExercises)
            {
                var exercise = GetExerciseByName(exercises, trainingExercise.Exercise.ToLower(), query.Language);

                trainingExercises.Add(new TrainingExerciseViewModel
                {
                    Name = exercise.GetExerciseName(query.Language),
                    MainMuscle = GetMuscleNameByLanguage(query.Language, exercise.Muscle.MainMuscle),
                    Muscle = exercise.Muscle.GetMuscleName(query.Language),
                    Reps = trainingExercise.Reps,
                    Sets = trainingExercise.Sets,
                    Observations = trainingExercise.Observations
                });
            }

            workouts.Add(new WorkoutViewModel(trainingExercises, query.Language));
        }

        return workouts;
    }

    private Exercise GetExerciseByName(List<Exercise> exercises, string exerciseName, ELanguage language) => language switch
        {
            ELanguage.English => exercises.FirstOrDefault(x => x.EnName.ToLower() == exerciseName),
            ELanguage.Portuguese => exercises.FirstOrDefault(x => x.PtName.ToLower() == exerciseName)
        };

    private string GetMuscleNameByLanguage(ELanguage language, EMuscle muscle) => (language, muscle) switch
    {
        (ELanguage.Portuguese, EMuscle.Chest) => "Peito",
        (ELanguage.Portuguese, EMuscle.Back) => "Costas",
        (ELanguage.Portuguese, EMuscle.Biceps) => "Bíceps",
        (ELanguage.Portuguese, EMuscle.Triceps) => "Tríceps",
        (ELanguage.Portuguese, EMuscle.Abs) => "Abdominais",
        (ELanguage.Portuguese, EMuscle.Calves) => "Panturrilhas",
        (ELanguage.Portuguese, EMuscle.Quadriceps) => "Quadríceps",
        (ELanguage.Portuguese, EMuscle.Glutes) => "Glúteos",
        (ELanguage.Portuguese, EMuscle.Forearms) => "Antebraços",
        (ELanguage.English, EMuscle.Chest) => "Chest",
        (ELanguage.English, EMuscle.Back) => "Back",
        (ELanguage.English, EMuscle.Biceps) => "Biceps",
        (ELanguage.English, EMuscle.Triceps) => "Triceps",
        (ELanguage.English, EMuscle.Abs) => "Abs",
        (ELanguage.English, EMuscle.Calves) => "Calves",
        (ELanguage.English, EMuscle.Quadriceps) => "Quadriceps",
        (ELanguage.English, EMuscle.Glutes) => "Glutes",
        (ELanguage.English, EMuscle.Forearms) => "Forearms",
    };

}