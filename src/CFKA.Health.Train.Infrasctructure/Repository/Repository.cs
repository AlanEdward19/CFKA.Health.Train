using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Infrastructure.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly CFKATrainDbContext _dbContext;
    private readonly DbSet<T> _dbSet;
    
    public Repository(CFKATrainDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<T>();
    }

    #region Add

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();
    }

    #endregion

    #region Update

    public async Task UpdateAsync(T entity, int id)
    {
        var entityDb = await GetById(id);

        foreach (var property in _dbSet.Entry(entityDb).Properties)
        {
            var propertyName = property.Metadata.Name;

            if (propertyName.ToLower() != "id")
                property.CurrentValue = _dbSet.Entry(entity).Property(propertyName).CurrentValue;
        }

        _dbSet.Update(entityDb);

        await _dbContext.SaveChangesAsync();
    }

    #endregion

    #region Get

    public async Task<List<T>> GetAll() => await _dbSet.VirtualInclude().ToListAsync();

    public async Task<T> GetById(int id)
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        var property = Expression.Property(parameter, "Id");
        var lambdaExpression = Expression.Lambda<Func<T, bool>>(Expression.Equal(property, Expression.Constant(id)), parameter);


        return await _dbSet.VirtualInclude().Where(lambdaExpression).FirstOrDefaultAsync();
    }

    #endregion

    #region Delete

    public async Task DeleteById(int id)
    {
        var entityDb = await GetById(id);

        _dbSet.Remove(entityDb);

        await _dbContext.SaveChangesAsync();
    }

    #endregion

}