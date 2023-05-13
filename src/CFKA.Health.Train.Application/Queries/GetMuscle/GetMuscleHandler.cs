namespace CFKA.Health.Application.Queries.GetMuscle;

public class GetMuscleHandler : IQueryHandler<Muscle>
{
    private readonly IRepository<Muscle> _repository;

    public GetMuscleHandler(IRepository<Muscle> repository)
    {
        _repository = repository;
    }

    public async Task<List<Muscle>> GetAll() => await _repository.GetAll();
    public async Task<Muscle> GetById(int id) => await _repository.GetById(id);
}