using Microsoft.Extensions.Logging;

namespace CFKA.Health.Application.Queries.GetExercise;

public class GetExerciseHandler : IQueryHandler<Exercise>
{
    private readonly IRepository<Exercise> _repository;
    private readonly ILogger<GetExerciseHandler> _logger;

    public GetExerciseHandler(IRepository<Exercise> repository, ILogger<GetExerciseHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<List<Exercise>> GetAll()
    {
        _logger.LogInformation($"Retrieving all Exercises");

        return await _repository.GetAll();
    }

    public async Task<Exercise> GetById(int id)
    {
        _logger.LogInformation($"Retrieving Exercise with id: {id}");
        return await _repository.GetById(id);
    }
}