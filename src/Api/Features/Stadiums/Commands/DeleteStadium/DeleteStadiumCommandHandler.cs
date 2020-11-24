using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Stadiums.Commands.DeleteStadium
{
    public class DeleteStadiumCommandHandler : IRequestHandler<DeleteStadiumCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteStadiumCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(DeleteStadiumCommand request, CancellationToken cancellationToken)
        {
            var stadium = await _context.Stadiums.FindAsync(request.Id, cancellationToken);

            if (stadium is null)
                throw new NotFoundException(nameof(Stadium), request.Id);

            _context.Stadiums.Remove(stadium);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
