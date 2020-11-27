using Api.Exceptions;
using Core.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Commands
{
    public abstract class DeleteEntityCommandHandler<TCommand, TEntity> : ICommandHandler<TCommand>
        where TCommand : EntityCommand
        where TEntity : Entity
    {
        protected readonly IApplicationDbContext _context;

        protected DeleteEntityCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Set<TEntity>().FindAsync(request.Id);

            if (entity is null)
                throw new NotFoundException(typeof(TCommand).Name, request.Id);

            _context.Entry(entity).State = EntityState.Deleted;

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
