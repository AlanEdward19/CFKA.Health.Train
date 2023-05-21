using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CFKA.Health.Infrastructure.Extensions;

public static class DbSetExtensions
{
    public static IQueryable<T> VirtualInclude<T>(this DbSet<T> dbSet) where T : class
    {
        var properties = typeof(T)
            .GetProperties()
            .Where(p => (p.PropertyType.Name.Contains("IEnumerable") && p.PropertyType.IsGenericType) || IsPropertyVirtual(p))
            .Select(p => p.Name);

        return properties.Aggregate(dbSet.AsQueryable(), (current, property) => current.Include(property));
    }

    private static bool IsPropertyVirtual(PropertyInfo property)
    {
        return property.GetGetMethod()?.IsVirtual ?? false;
    }



}