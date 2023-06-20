using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Extensions;
using CFKA.Health.Train.Application.Queries.BuildTrainingSheet;
using CFKA.Health.Train.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CFKA.Health.Train.Application.Handler;

public class TrainingHandler
{
    private readonly DbSet<Training> _trainings;
    private readonly ILogger<TrainingHandler> _logger;

    public TrainingHandler(CFKATrainDbContext dbContext, ILogger<TrainingHandler> logger)
    {
        _trainings = dbContext.Trainings;
        _logger = logger;
    }

    public async Task<IEnumerable<TrainingViewModel>> GetAll(string owner)
    {
        var database =  await _trainings.Include(x => x.TrainingExercises).ThenInclude(x => x.Exercise)
            .ThenInclude(x => x.Muscle).Where(x => x.Owner.Equals(owner)).ToListAsync();

        List<TrainingViewModel> training = (from trainingDb in database select TrainingViewModel.ToEntity(trainingDb)).ToList();

        return training;
    }

    public async Task<TrainingViewModel> GetById(string owner, int id)
    {
        var database =  await _trainings.Include(x => x.TrainingExercises).ThenInclude(x => x.Exercise)
            .ThenInclude(x => x.Muscle).Where(x => x.Id.Equals(id) && x.Owner.Equals(owner)).FirstOrDefaultAsync();

        return TrainingViewModel.ToEntity(database!);
    }

    //public async Task<TrainingSheetViewModel> BuildTrainingSheet(BuildTrainingSheetQuery query)
    //{
    //    _logger.LogInformation("Initializing trainingSheet build");

    //    var queryWorkoutList = query.Workouts.SelectMany(x => x.TrainingExercises.Select(y => y.Exercise.ToLower()))
    //        .ToList();

    //    _logger.LogInformation("Retrieving exercises by name");
    //    var exercises = await _exercises.VirtualInclude().Where(exercise =>
    //        queryWorkoutList.Contains(query.Language == ELanguage.English
    //            ? exercise.EnName.ToLower()
    //            : exercise.PtName.ToLower())).ToListAsync();
    //    _logger.LogInformation("Exercises retrieved");

    //    _logger.LogInformation("Building workout");

    //    var workouts = BuildWorkouts(query, exercises);

    //    _logger.LogInformation($"Workout built, with changeDate defined to: {query.ChangeDate}");

    //    var trainingSheet = new TrainingSheetViewModel
    //    {
    //        Workouts = workouts,
    //        ChangeDate = query.ChangeDate
    //    };

    //    return trainingSheet;
    //}

    //private List<WorkoutViewModel> BuildWorkouts(BuildTrainingSheetQuery query, List<Exercise> exercises)
    //{
    //    var workouts = new List<WorkoutViewModel>();

    //    foreach (var workout in query.Workouts)
    //    {
    //        var trainingExercises = new List<TrainingExerciseViewModel>();

    //        foreach (var trainingExercise in workout.TrainingExercises)
    //        {
    //            var exercise = GetExerciseByName(exercises, trainingExercise.Exercise.ToLower(), query.Language);

    //            trainingExercises.Add(new TrainingExerciseViewModel
    //            {
    //                Name = exercise.GetExerciseName(query.Language),
    //                MainMuscle = GetMuscleNameByLanguage(query.Language, exercise.Muscle.MainMuscle),
    //                Muscle = exercise.Muscle.GetMuscleName(query.Language),
    //                Reps = trainingExercise.Reps,
    //                Sets = trainingExercise.Sets,
    //                Observations = trainingExercise.Observations
    //            });
    //        }

    //        workouts.Add(new WorkoutViewModel(trainingExercises, query.Language));
    //    }

    //    return workouts;
    //}
}