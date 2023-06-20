using CFKA.Health.Domain.Entities;
using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Extensions;
using CFKA.Health.Train.Application.InputModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CFKA.Health.Train.Application.Commands.CreateUpdateTraining;

public class CreateUpdateTrainingCommandHandler : ICommandHandler
{
    private readonly IRepository<Training> _repository;
    private readonly ILogger<Training> _logger;

    private readonly DbSet<Exercise> _exercises;

    public CreateUpdateTrainingCommandHandler(IRepository<Training> repository, ILogger<Training> logger, CFKATrainDbContext dbContext)
    {
        _repository = repository;
        _exercises = dbContext.Exercises;
        _logger = logger;
    }

    public async Task Insert(ICommand command)
    {
        _logger.LogInformation("Initialing insertion of new Training");
        var model = command as CreateUpdateTrainingCommand;

        var exercisesId = model.TrainingExercises.Select(x => x.ExerciseId).ToList();
        List<Exercise> exercises = await _exercises.VirtualInclude().Where(x => exercisesId.Contains(x.Id)).ToListAsync();
        List<TrainingExercise> trainingExercises = new();

        Training training = new(model.Owner, model.ChangeDate);

        foreach (var trainingExercise in model.TrainingExercises)
        { 
            var exercise = exercises.FirstOrDefault(x => x.Id.Equals(trainingExercise.ExerciseId));

            trainingExercises.Add(TrainingExerciseInputModel.ToEntity(exercise, trainingExercise));
        }

        training.SetTrainingExercise(trainingExercises);
        training.SetTrainingName();
        await _repository.AddAsync(training);
    }

    public async Task Update(ICommand command, int id) // Avaliar
    {
        _logger.LogInformation("Initialing insertion of new Training");
        var model = command as CreateUpdateTrainingCommand;

        var exercisesId = model.TrainingExercises.Select(x => x.ExerciseId).ToList();
        List<Exercise> exercises = await _exercises.Where(x => exercisesId.Contains(x.Id)).ToListAsync();
        List<TrainingExercise> trainingExercises = new();

        Training training = new(model.Owner, model.ChangeDate);

        foreach (var trainingExercise in model.TrainingExercises)
        {
            var exercise = exercises.FirstOrDefault(x => x.Id.Equals(trainingExercise.ExerciseId));

            trainingExercises.Add(TrainingExerciseInputModel.ToEntity(exercise, trainingExercise));
        }

        training.SetTrainingExercise(trainingExercises);
        training.SetTrainingName();
        await _repository.UpdateAsync(training, id);
    }

    public async Task Delete(int id) // Avaliar
    {
        _logger.LogInformation("Initialing deletion of new Training");

        _logger.LogInformation($"Deleting Training with id: {id}");

        await _repository.DeleteById(id);

        _logger.LogInformation($"Training of id: {id} deleted!");
    }
}