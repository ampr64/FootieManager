using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Common
{
    public interface IRepository<TEntity, TId>
        where TEntity : Entity<TId>
    {
        Task<TEntity> FindAsync(TId id, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<IReadOnlyList<TEntity>> ListAllAsync(string includeProperties = null);
        Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, string includeProperties = null);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> ContainsAsync(TEntity entity);
        Task ForEachAsync(Action<TEntity> action);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task RemoveAsync(TId id);
    }
}
