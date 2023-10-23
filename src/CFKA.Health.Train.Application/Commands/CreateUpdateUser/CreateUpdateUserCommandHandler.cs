using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Train.Application.Commands.CreateUpdateUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CFKA.Health.Application.Commands.CreateUpdateExercise;

public class CreateUpdateUserCommandHandler : ICommandHandler
{
    private readonly IRepository<User> _repository;
    private readonly ILogger<CreateUpdateUserCommandHandler> _logger;

    private readonly DbSet<User> _users;

    public CreateUpdateUserCommandHandler(IRepository<User> repository, CFKATrainDbContext dbContext, ILogger<CreateUpdateUserCommandHandler> logger)
    {
        _repository = repository;
        _users = dbContext.Users;
        _logger = logger;
    }

    public async Task Insert(ICommand command)
    {
        _logger.LogInformation("Initialing insertion of new User");

        var model = command as CreateUpdateUserCommand;

        User user = new()
        {
            Email = model.Email,
            FirstName = model.FirstName,
            LastName = model.LastName,
            Password = model.Password,
            TrainerId = model.TrainerId,
            UserType = model.TrainerId == null ? EUserType.Trainer : EUserType.Client
        };

        await _repository.AddAsync(user);

        _logger.LogInformation("User created!");
    }

    public async Task Update(ICommand command, Guid id)
    {
        _logger.LogInformation($"Initialing updating of User with id: '{id}'");

        var model = command as CreateUpdateUserCommand;

        _logger.LogInformation($"Retrieving User of email: {model!.Email}");

        User user = await _users.FirstAsync(x => x.Id.Equals(id));

        user.Email = string.IsNullOrWhiteSpace(model.Email) ? user.Email : model.Email;
        user.FirstName = string.IsNullOrWhiteSpace(model.FirstName) ? user.FirstName : model.FirstName;
        user.LastName = string.IsNullOrWhiteSpace(model.LastName) ? user.LastName : model.LastName;
        user.Password = string.IsNullOrWhiteSpace(model.Password) ? user.Password : model.Password;
        user.TrainerId = string.IsNullOrWhiteSpace(model.TrainerId.ToString()) ? user.TrainerId : model.TrainerId;
        user.UserType = user.TrainerId == null ? EUserType.Trainer : EUserType.Client;

        await _repository.UpdateAsync(user, id);

        _logger.LogInformation("Exercise updated!");
    }

    public async Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Update(ICommand command, int id)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Guid id)
    {
        _logger.LogInformation("Initialing deletion of User");

        _logger.LogInformation($"Deleting User with id: '{id}'");

        await _repository.DeleteById(id);

        _logger.LogInformation($"User of id: {id} deleted!");
    }
}