using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Common
{
    public interface IEntityService<TEntity, TId>
        where TEntity : Entity<TId>
    {
        Task NewAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);        
        Task DeleteAsync(TEntity entity);        
        Task DeleteAsync(TId id);
        Task<TEntity> GetByIdAsync(TId id);
        Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> predicate);        
        Task<IReadOnlyList<TEntity>> GetAllAsync();        
        Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
