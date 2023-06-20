using CFKA.Health.Domain.Entities;
using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Extensions;
using CFKA.Health.Train.Application.Commands.CreateUpdateTraining;
using CFKA.Health.Train.Application.InputModels;
using CFKA.Health.Train.Application.Queries.BuildTrainingSheet;
using CFKA.Health.Train.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CFKA.Health.Train.Application.Handler;

public class TrainingHandler
{
    private readonly DbSet<Training> _trainings;
    private readonly DbSet<Exercise> _exercises;

    private readonly ILogger<TrainingHandler> _logger;
    private readonly IRepository<Training> _repository;

    public TrainingHandler(CFKATrainDbContext dbContext, ILogger<TrainingHandler> logger, IRepository<Training> repository)
    {
        _trainings = dbContext.Trainings;
        _exercises = dbContext.Exercises;
        _logger = logger;
        _repository = repository;
    }

    public async Task<IEnumerable<TrainingViewModel>> GetAll(string owner, ELanguage language)
    {
        var database =  await _trainings.Include(x => x.TrainingExercises).ThenInclude(x => x.Exercise)
            .ThenInclude(x => x.Muscle).Where(x => x.Owner.Equals(owner)).ToListAsync();

        List<TrainingViewModel> training = (from trainingDb in database select TrainingViewModel.ToEntity(trainingDb, language)).ToList();

        return training;
    }

    public async Task<TrainingViewModel> GetById(string owner, int id, ELanguage language)
    {
        var database =  await _trainings.Include(x => x.TrainingExercises).ThenInclude(x => x.Exercise)
            .ThenInclude(x => x.Muscle).Where(x => x.Id.Equals(id) && x.Owner.Equals(owner)).FirstOrDefaultAsync();

        return TrainingViewModel.ToEntity(database!, language);
    }

    public async Task Insert(CreateUpdateTrainingCommand command, string owner)
    {
        _logger.LogInformation("Initialing insertion of new Training");

        var exercisesId = command.TrainingExercises.Select(x => x.ExerciseId).ToList();
        List<Exercise> exercises = await _exercises.VirtualInclude().Where(x => exercisesId.Contains(x.Id)).ToListAsync();
        List<TrainingExercise> trainingExercises = new();

        Training training = new(owner, command.ChangeDate);

        foreach (var trainingExercise in command.TrainingExercises)
        {
            var exercise = exercises.FirstOrDefault(x => x.Id.Equals(trainingExercise.ExerciseId));

            trainingExercises.Add(TrainingExerciseInputModel.ToEntity(exercise, trainingExercise));
        }

        training.SetTrainingExercise(trainingExercises);
        training.SetTrainingName();
        await _repository.AddAsync(training);
    }

    public async Task Update(CreateUpdateTrainingCommand command, int id, string owner) // Avaliar
    {
        _logger.LogInformation("Initialing insertion of new Training");

        if (await Validate(id, owner))
        {
            var exercisesId = command.TrainingExercises.Select(x => x.ExerciseId).ToList();
            List<Exercise> exercises = await _exercises.Where(x => exercisesId.Contains(x.Id)).ToListAsync();
            List<TrainingExercise> trainingExercises = new();

            Training training = new(owner, command.ChangeDate);

            foreach (var trainingExercise in command.TrainingExercises)
            {
                var exercise = exercises.FirstOrDefault(x => x.Id.Equals(trainingExercise.ExerciseId));

                trainingExercises.Add(TrainingExerciseInputModel.ToEntity(exercise, trainingExercise));
            }

            training.SetTrainingExercise(trainingExercises);
            training.SetTrainingName();
            await _repository.UpdateAsync(training, id);
        }

        else
            _logger.LogInformation($"Owner of training of id: {id} doesn't match {owner}");
    }

    public async Task Delete(int id, string owner) // Avaliar
    {
        _logger.LogInformation("Initialing deletion of new Training");

        if (await Validate(id, owner))
        {
            _logger.LogInformation($"Deleting Training with id: {id}");

            await _repository.DeleteById(id);

            _logger.LogInformation($"Training of id: {id} deleted!");
        }
        
        else
            _logger.LogInformation($"Owner of training of id: {id} doesn't match {owner}");
        
    }

    private async Task<bool> Validate(int id, string owner)
    {
        var entity = await _repository.GetById(id);

        return entity.Owner.Equals(owner);
    }
}