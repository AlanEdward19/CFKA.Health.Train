using Microsoft.Extensions.Logging;

namespace CFKA.Health.Application.Queries.GetMuscle;

public class GetUserHandler : IQueryHandler<User>
{
    private readonly IRepository<User> _repository;
    private readonly ILogger<GetUserHandler> _logger;

    public GetUserHandler(IRepository<User> repository, ILogger<GetUserHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<List<User>> GetAll()
    {
        _logger.LogInformation($"Retrieving all Users");

        return await _repository.GetAll();
    }

    public async Task<User> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetById(Guid id)
    {
        _logger.LogInformation($"Retrieving User with id: {id}");

        return await _repository.GetById(id);
    }
}