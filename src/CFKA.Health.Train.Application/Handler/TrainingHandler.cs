using CFKA.Health.Domain.Entities;
using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Infrastructure.Extensions;
using CFKA.Health.Infrastructure.Migrations;
using CFKA.Health.Train.Application.Commands.CreateUpdateTraining;
using CFKA.Health.Train.Application.InputModels;
using CFKA.Health.Train.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Training = CFKA.Health.Domain.Entities.Training;

namespace CFKA.Health.Train.Application.Handler;

public class TrainingHandler
{
    private readonly DbSet<User> _users;
    private readonly DbSet<Training> _trainings;
    private readonly DbSet<Exercise> _exercises;

    private readonly ILogger<TrainingHandler> _logger;
    private readonly IRepository<Training> _repository;

    public TrainingHandler(CFKATrainDbContext dbContext, ILogger<TrainingHandler> logger, IRepository<Training> repository)
    {
        _users = dbContext.Users;
        _trainings = dbContext.Trainings;
        _exercises = dbContext.Exercises;
        _logger = logger;
        _repository = repository;
    }

    public async Task<IEnumerable<TrainingViewModel>> GetAll(string? ownerId, ELanguage language)
    {
        CheckApiKey(ownerId);

        User? owner = await _users.FirstOrDefaultAsync(x => x.Id.Equals(Guid.Parse(ownerId)));

        if(owner == null)
            throw new InvalidOperationException($"No user was found with id: {ownerId}");

        var database = await _trainings.Include(x => x.TrainingExercises).ThenInclude(x => x.Exercise)
            .ThenInclude(x => x.Muscle).Where(x => x.Owner.Equals(owner)).ToListAsync();

        List<TrainingViewModel> training = (from trainingDb in database select TrainingViewModel.ToEntity(trainingDb, language)).ToList();

        return training;
    }

    public async Task<ClientTrainingViewModel> GetClientTraining(string? trainerId, string clientId, ELanguage language)
    {
        CheckApiKey(trainerId);

        User? client = await _users.Include(x => x.Trainings).ThenInclude(x => x.TrainingExercises)
            .ThenInclude(x => x.Exercise).ThenInclude(x => x.Muscle)
            .FirstOrDefaultAsync(x => x.TrainerId.Equals(Guid.Parse(trainerId)) && x.Id.Equals(Guid.Parse(clientId)));

        if(client == null)
            throw new InvalidOperationException($"No user was found with id: {clientId} for this trainer");

        ClientTrainingViewModel clientTraining = new($"{client.FirstName} {client.LastName}", client.Email,
            (from trainingDb in client.Trainings select TrainingViewModel.ToEntity(trainingDb, language)));

        return clientTraining;
    }

    public async Task<IEnumerable<ClientTrainingViewModel>> GetAllClientsTraining(string? trainerId, ELanguage language)
    {
        CheckApiKey(trainerId);

        List<User> clients = await _users.Where(x => x.TrainerId.Equals(Guid.Parse(trainerId))).Include(x => x.Trainings)
            .ThenInclude(x => x.TrainingExercises).ThenInclude(x => x.Exercise).ThenInclude(x => x.Muscle)
            .ToListAsync();

        List<ClientTrainingViewModel> clientsTrainingList = (from clientDb in clients
            select new ClientTrainingViewModel($"{clientDb.FirstName} {clientDb.LastName}", clientDb.Email,
                (from trainingDb in clientDb.Trainings select TrainingViewModel.ToEntity(trainingDb, language)))).ToList();

        return clientsTrainingList;
    }

    public async Task<TrainingViewModel> GetById(string? ownerId, int id, ELanguage language)
    {
        CheckApiKey(ownerId);

        User? owner = await _users.FirstOrDefaultAsync(x => x.Id.Equals(Guid.Parse(ownerId)));

        if (owner == null)
            throw new InvalidOperationException($"No user was found with id: {ownerId}");

        if (await Validate(id, owner))
        {
            var database = await _trainings.Include(x => x.TrainingExercises).ThenInclude(x => x.Exercise)
                .ThenInclude(x => x.Muscle).Where(x => x.Id.Equals(id) && x.Owner.Equals(owner)).FirstOrDefaultAsync();

            return TrainingViewModel.ToEntity(database!, language);
        }
        else
        {
            _logger.LogInformation($"Owner of training of id: '{id}' doesn't match '{owner.Id}'");
            throw new InvalidOperationException("Can't get a training that isn't yours");
        }
    }

    public async Task Insert(CreateUpdateTrainingCommand command, string ownerId, string? trainerId)
    {
        _logger.LogInformation("Initialing insertion of new Training");

        CheckApiKey(trainerId);

        User owner = await _users.FirstAsync(x => x.Id.Equals(Guid.Parse(ownerId)));
        User trainer = await _users.FirstAsync(x => x.Id.Equals(Guid.Parse(trainerId)));

        if (trainer.UserType == EUserType.Client)
        {
            throw new InvalidOperationException("Only trainer's can create training");
        } 

        var exercisesId = command.TrainingExercises.Select(x => x.ExerciseId).ToList();
        List<Exercise> exercises = await _exercises.VirtualInclude().Where(x => exercisesId.Contains(x.Id)).ToListAsync();
        List<TrainingExercise> trainingExercises = new();

        Training training = new(command.ChangeDate, owner, trainer);

        foreach (var trainingExercise in command.TrainingExercises)
        {
            var exercise = exercises.FirstOrDefault(x => x.Id.Equals(trainingExercise.ExerciseId));

            trainingExercises.Add(TrainingExerciseInputModel.ToEntity(exercise, trainingExercise));
        }

        training.SetTrainingExercise(trainingExercises);
        training.SetTrainingName();
        await _repository.AddAsync(training);
    }

    public async Task Update(CreateUpdateTrainingCommand command, int id, string ownerId, string? trainerId)
    {
        _logger.LogInformation("Initialing update of new Training");

        CheckApiKey(trainerId);

        User owner = await _users.FirstAsync(x => x.Id.Equals(Guid.Parse(ownerId)));
        User trainer = await _users.FirstAsync(x => x.Id.Equals(Guid.Parse(trainerId)));

        if (trainer.UserType == EUserType.Client)
        {
            throw new InvalidOperationException("Only trainer's can update training");
        }

        if (await Validate(id, owner))
        {
            var exercisesId = command.TrainingExercises.Select(x => x.ExerciseId).ToList();
            List<Exercise> exercises = await _exercises.Where(x => exercisesId.Contains(x.Id)).ToListAsync();
            List<TrainingExercise> trainingExercises = new();

            Training training = new(command.ChangeDate, owner, trainer);

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
        {
            _logger.LogInformation($"Owner of training of id: '{id}' doesn't match '{owner.Id}'");
            throw new InvalidOperationException("Can't update a training that isn't yours");
        }
            
    }

    public async Task Delete(int id, string? ownerId, string trainerId)
    {
        _logger.LogInformation("Initialing deletion of new Training");

        CheckApiKey(ownerId);

        User owner = await _users.FirstAsync(x => x.Id.Equals(Guid.Parse(ownerId)));
        User trainer = await _users.FirstAsync(x => x.Id.Equals(Guid.Parse(trainerId)));

        if (trainer.UserType == EUserType.Client)
        {
            throw new InvalidOperationException("Only trainer's can delete training");
        }

        if (await Validate(id, owner))
        {
            _logger.LogInformation($"Deleting Training with id: '{id}'");

            await _repository.DeleteById(id);

            _logger.LogInformation($"Training of id: '{id}' deleted!");
        }

        else
        {
            _logger.LogInformation($"Owner of training of id: '{id}' doesn't match '{owner.Id}'");
            throw new InvalidOperationException("Can't delete a training that isn't yours");
        }
        
    }

    private async Task<bool> Validate(int id, User owner)
    {
        var entity = await _repository.GetById(id);

        return entity.Owner.Equals(owner);
    }

    private void CheckApiKey(string? key)
    {
        if(string.IsNullOrWhiteSpace(key))
            throw new InvalidOperationException("No api-key were found on headers, please check");
    }
}