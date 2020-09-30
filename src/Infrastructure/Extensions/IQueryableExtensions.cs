using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> source, Expression<Func<T, object>>[] navigationProperties)
            where T : class =>
                navigationProperties?.Aggregate(source, (query, property) => source?.Include(property));

        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> source, string navigationProperties)
            where T : class
        {
            if (!string.IsNullOrEmpty(navigationProperties))
            {
                var properties = navigationProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(props => props.Trim());
                source = properties.Aggregate(source, (query, property) => query.Include(property));
            }
            return source;
        }
    }
}
