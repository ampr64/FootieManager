using Application.Common;
using Core.Common;
using Core.Services;
using Domain.Common;
using Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public abstract class ApplicationService<TEntity, TId> : IService<TEntity, TId>
        where TEntity : Entity<TId>
    {
        private readonly IUnitOfWork _unitOfWork;
        protected readonly IRepository<TEntity, TId> _repository;

        protected ApplicationService(IUnitOfWork unitOfWork, IRepository<TEntity, TId> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual async Task<TEntity> GetByIdAsync(TId id) => await _repository.FindAsync(id);

        public virtual async Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> predicate) => await _repository.FirstOrDefaultAsync(predicate);

        public virtual async Task<IReadOnlyList<TEntity>> GetAllAsync() => await _repository.ListAllAsync();

        public virtual async Task<IReadOnlyList<TEntity>> FilterAsync(Expression<Func<TEntity, bool>> filter) => await _repository.ListAsync(filter);

        public virtual async Task NewAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
            await _unitOfWork.CommitChangesAsync();
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            await _repository.RemoveAsync(entity);
            await _unitOfWork.CommitChangesAsync();
        }

        public virtual async Task DeleteAsync(TId id)
        {
            await _repository.RemoveAsync(id);
            await _unitOfWork.CommitChangesAsync();
        }

        protected async Task<IReadOnlyList<TEntity>> FilterAsync(Expression<Func<TEntity, bool>> filter, string navigationProperties) =>
            await _repository.ListAsync(filter, navigationProperties);

        protected async Task<IReadOnlyList<TEntity>> GetAllAsync(string navigationProperties) =>
            await _repository.ListAllAsync(navigationProperties);

        protected async Task<TEntity> GetByIdAsync(TId id, params Expression<Func<TEntity, object>>[] navigationProperties) =>
            await _repository.FindAsync(id, navigationProperties);

        protected async Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] navigationProperties) =>
            await _repository.FirstOrDefaultAsync(predicate, navigationProperties);
    }
}
