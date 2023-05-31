using Microsoft.Extensions.Logging;

namespace CFKA.Health.Application.Queries.GetMuscle;

public class GetMuscleHandler : IQueryHandler<Muscle>
{
    private readonly IRepository<Muscle> _repository;
    private readonly ILogger<GetMuscleHandler> _logger;

    public GetMuscleHandler(IRepository<Muscle> repository, ILogger<GetMuscleHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<List<Muscle>> GetAll()
    {
        _logger.LogInformation($"Retrieving all Muscles");

        return await _repository.GetAll();
    }

    public async Task<Muscle> GetById(int id)
    {
        _logger.LogInformation($"Retrieving Muscle with id: {id}");

        return await _repository.GetById(id);
    }
}