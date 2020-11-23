using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Commands.DeletePlayer
{
    public class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeletePlayerCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(DeletePlayerCommand request, CancellationToken cancellationToken)
        {
            var coach = await _context.Players.FindAsync(request.Id);

            if (coach is null)
                throw new NotFoundException(nameof(Club), request.Id);

            _context.Players.Remove(coach);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
