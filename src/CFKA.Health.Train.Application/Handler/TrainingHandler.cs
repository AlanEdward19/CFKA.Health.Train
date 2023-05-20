using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Train.Application.Queries.BuildTrainingSheet;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CFKA.Health.Infrastructure.Extensions;
using CFKA.Health.Train.Application.ViewModels;

namespace CFKA.Health.Train.Application.Handler;

public class TrainingHandler
{
    private readonly DbSet<Exercise> _exercises;

    public TrainingHandler(CFKATrainDbContext dbContext)
    {
        _exercises = dbContext.Set<Exercise>();
    }
    public async Task<TrainingSheetViewModel> BuildTrainingSheet(BuildTrainingSheetQuery query)
    {
        var queryWorkoutList = query.Workouts.SelectMany(x => x.TrainingExercises.Select(y => y.Exercise.ToLower()))
            .ToList();

        List<Exercise> exercises = await _exercises.VirtualInclude().Where(exercise =>
            queryWorkoutList.Contains(exercise.Name.ToLower())).ToListAsync();

        #region Workouts

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

        TrainingSheetViewModel trainingSheet = new()
        {
            Workouts = workouts,
            ChangeDate = query.ChangeDate
        };

        return trainingSheet;
    }
}