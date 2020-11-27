using Api.Exceptions;
using Core.Common;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Commands
{
    public abstract class UpdateEntityCommandHandler<TCommand, TEntity> : ICommandHandler<TCommand>
        where TCommand : EntityCommand
        where TEntity : Entity
    {
        protected readonly IApplicationDbContext _context;

        public UpdateEntityCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Set<TEntity>().FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity is null)
                throw new NotFoundException(typeof(TEntity).Name, request.Id);

            _context.Entry(entity).CurrentValues.SetValues(request);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
