using Api.Exceptions;
using ApplicationCore.Common;
using ApplicationCore.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Commands
{
    public abstract class UpdateCommandHandlerBase<TCommand, TEntity> : ICommandHandler<TCommand>
        where TCommand : UpdateCommand
        where TEntity : Entity
    {
        protected readonly IApplicationDbContext _context;

        public UpdateCommandHandlerBase(IApplicationDbContext context) => _context = context;

        public virtual async Task<Unit> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Set<TEntity>().FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity is null)
                throw new NotFoundException(typeof(TEntity).Name, request.Id);

            _context.Entry(entity).CurrentValues.SetValues(request);

            await _context.CommitAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
