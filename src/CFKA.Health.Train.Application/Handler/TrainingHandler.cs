using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Train.Application.Queries.BuildTrainingSheet;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CFKA.Health.Infrastructure.Extensions;
using CFKA.Health.Train.Application.ViewModels;
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
        List<Exercise> exercises = await _exercises.VirtualInclude().Where(exercise =>
            queryWorkoutList.Contains(exercise.Name.ToLower())).ToListAsync();
        _logger.LogInformation("Exercises retrieved");

        #region Workouts

        _logger.LogInformation("Building workout");

        List<WorkoutViewModel> workouts = new();

        foreach (var workout in query.Workouts)
        {
            List<TrainingExerciseViewModel> trainingExercises = new();

            foreach (var trainingExercise in workout.TrainingExercises)
            {
                Exercise exercise = exercises
                    .FirstOrDefault(x => x.Name.ToLower() == trainingExercise.Exercise.ToLower());

                trainingExercises.Add(new()
                {
                    Name = exercise!.Name,
                    MainMuscle = exercise.Muscle.MainMuscle.ToString(),
                    Muscle = exercise.Muscle.Name,
                    Reps = trainingExercise.Reps,
                    Sets = trainingExercise.Sets,
                    Observations = trainingExercise.Observations
                });
            }

            workouts.Add(new(trainingExercises));
        }

        #endregion

        _logger.LogInformation($"Workout built, with changeDate defined to: {query.ChangeDate}");

        TrainingSheetViewModel trainingSheet = new()
        {
            Workouts = workouts,
            ChangeDate = query.ChangeDate
        };

        return trainingSheet;
    }
}