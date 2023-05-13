namespace CFKA.Health.Application.Queries.GetExercise;

public class GetExerciseHandler : IQueryHandler<Exercise>
{
    private readonly IRepository<Exercise> _repository;

    public GetExerciseHandler(IRepository<Exercise> repository)
    {
        _repository = repository;
    }

    public async Task<List<Exercise>> GetAll() => await _repository.GetAll();
    public async Task<Exercise> GetById(int id) => await _repository.GetById(id);
}