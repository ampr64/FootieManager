﻿using Core.Common;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Commands
{
    public abstract class NewEntityCommandHandler<TCommand, TEntity> : ICommandHandler<TCommand, int>
        where TCommand : ICommand<int>
        where TEntity : Entity
    {        
        protected readonly IApplicationDbContext _context;

        public NewEntityCommandHandler(IApplicationDbContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        public async Task<int> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = CreateInstanceFromCommand(request);

            await _context.Set<TEntity>().AddAsync(entity, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return entity.Id;
        }

        protected abstract TEntity CreateInstanceFromCommand(TCommand request);
    }
}