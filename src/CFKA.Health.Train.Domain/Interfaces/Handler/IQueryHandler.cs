namespace CFKA.Health.Domain.Interfaces.Handler;

public interface IQueryHandler<T>
{
    Task<List<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> GetById(Guid id);
}