using CFKA.Health.Domain.Entities;
using CFKA.Health.Domain.ValueObjects;
using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Train.Application.Queries.BuildTrainingSheet;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CFKA.Health.Train.Application.Handler;

public class TrainingHandler
{
    private readonly DbSet<Exercise> _exercises;

    public TrainingHandler(CFKATrainDbContext dbContext)
    {
        _exercises = dbContext.Exercises;
    }
    public async Task<TrainingSheet> BuildTrainingSheet(BuildTrainingSheetQuery query)
    {
        List<Exercise> exercises = await _exercises.Where(exercise =>
            query.Workouts.Select(x => x.TrainingExercises.SelectMany(y => y.Exercise.ToLower())).ToList()
                .Contains(exercise.Name.ToLower())).ToListAsync();

        #region Workouts

        List<Workout> workouts = new();

        foreach (var workout in query.Workouts)
        {
            List<TrainingExercise> trainingExercises = new();

            foreach (var trainingExercise in workout.TrainingExercises)
            {
                Exercise exercise = exercises
                    .FirstOrDefault(x => x.Name.ToLower() == trainingExercise.Exercise.ToLower());

                trainingExercises.Add(new()
                {
                    Exercise = exercise,
                    Reps = trainingExercise.Reps,
                    Sets = trainingExercise.Sets,
                    Observations = trainingExercise.Observations
                });
            }

            workouts.Add(new(trainingExercises));
        }

        #endregion

        TrainingSheet trainingSheet = new()
        {
            Workouts = workouts,
            ChangeDate = query.ChangeDate
        };

        return trainingSheet;
    }
}