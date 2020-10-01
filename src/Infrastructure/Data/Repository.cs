using Core.Common;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : IEquatable<TId>
    {
        protected readonly FootieManagerContext _dbContext;

        public Repository(FootieManagerContext context)
        {
            _dbContext = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            return entity;
        }

        public async Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate) => await _dbContext.Set<TEntity>().AllAsync(predicate);

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate) => await _dbContext.Set<TEntity>().AnyAsync(predicate);

        public async Task<bool> ContainsAsync(TEntity entity) => await _dbContext.Set<TEntity>().ContainsAsync(entity);

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null) => await _dbContext.Set<TEntity>().CountAsync(predicate);

        public async Task<TEntity> FindAsync(TId id, params Expression<Func<TEntity, object>>[] includeProperties) =>
            await _dbContext.Set<TEntity>()
                .IncludeMultiple(includeProperties)
                .SingleOrDefaultAsync(entity => entity.Id.Equals(id));

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task ForEachAsync(Action<TEntity> action)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<TEntity>> ListAllAsync(string includeProperties = null) =>
            await _dbContext.Set<TEntity>()
                            .Include(includeProperties)
                            .ToListAsync();

        public async Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, string includeProperties) =>
            await _dbContext.Set<TEntity>()
                            .Include(includeProperties)
                            .Where(predicate)
                            .ToListAsync();

        public Task RemoveAsync(TEntity entity)
        {
            _dbContext.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task RemoveAsync(TId id)
        {
            var entity = await _dbContext.FindAsync<TEntity>(id);
            _dbContext.Remove(entity);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties) => await _dbContext.Set<TEntity>().SingleOrDefaultAsync(predicate);

        public Task UpdateAsync(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
