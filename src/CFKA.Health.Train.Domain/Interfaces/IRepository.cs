namespace CFKA.Health.Domain.Interfaces;

public interface IRepository<T>
{
    Task<List<T>> GetAll();
    Task<T> GetById(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity, int id);
    Task DeleteById(int id);
}