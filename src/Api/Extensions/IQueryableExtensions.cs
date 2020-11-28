using System;
using System.Linq;
using System.Linq.Expressions;

namespace Api.Extensions
{
    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public static class IQueryableExtensions
    {
        public static IOrderedQueryable<T> OrderByCriterias<T, TKey>(this IQueryable<T> query, params (Expression<Func<T, TKey>> KeySelector, SortDirection Direction)[] sortCriterias)
            where T : class
        {
            IOrderedQueryable<T> result = null;

            if (sortCriterias != null && sortCriterias.Any())
            {
                result = ApplyOrder(query, sortCriterias[0]);

                if (sortCriterias.Length > 1)
                {
                    sortCriterias.Skip(1).Aggregate(result, (orderedSequence, criteria) =>
                        ApplyOrder(orderedSequence, criteria));
                }
            }

            return result;
        }

        private static IOrderedQueryable<T> ApplyOrder<T, TKey>(IQueryable<T> query, (Expression<Func<T, TKey>> KeySelector, SortDirection Direction) sortCriteria)
            where T : class
        {
            IOrderedQueryable<T> result;

            if (typeof(IOrderedQueryable).IsAssignableFrom(query.Expression.Type))
            {
                result = query as IOrderedQueryable<T>;
                result = sortCriteria.Direction == SortDirection.Ascending
                    ? result.ThenBy(sortCriteria.KeySelector)
                    : result.ThenByDescending(sortCriteria.KeySelector);
            }
            else
            {
                result = sortCriteria.Direction == SortDirection.Ascending
                    ? query.OrderBy(sortCriteria.KeySelector)
                    : query.OrderByDescending(sortCriteria.KeySelector);
            }

            return result;
        }
    }
}
