using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Infrastructure.Extensions;

public static class DbSetExtensions
{
    public static IQueryable<T> VirtualInclude<T>(this DbSet<T> dbSet) where T : class
    {
        var properties = dbSet
            .GetType()
            .GetProperties()
            .Where(p => p.PropertyType.Name.Contains("IEnumerable") && p.PropertyType.IsGenericType)
            .Select(p => p.Name);

        return properties.Aggregate(dbSet.AsQueryable(), (current, property) => current.Include(property));
    }
}