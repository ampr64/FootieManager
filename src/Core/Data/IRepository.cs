using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Data
{
    public interface IRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        public Task<TEntity> FindAsync(TId id, params Expression<Func<TEntity, object>>[] includeProperties);
        public Task<IReadOnlyList<TEntity>> ListAllAsync(string includeProperties = null);
        public Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, string includeProperties = null);
        public Task<TEntity> AddAsync(TEntity entity);
        public Task UpdateAsync(TEntity entity);
        public Task RemoveAsync(TEntity entity);
        public Task RemoveAsync(TId id);
        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
