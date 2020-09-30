using Domain.Common;
using Domain.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : Entity<TId>
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(TId id, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TEntity>> ListAllAsync(string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, string includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
