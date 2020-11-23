using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Commands.DeleteCoach
{
    public class DeleteCoachCommandHandler : IRequestHandler<DeleteCoachCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCoachCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(DeleteCoachCommand request, CancellationToken cancellationToken)
        {
            var coach = await _context.Coaches.FindAsync(request.Id);

            if (coach is null)
                throw new NotFoundException(nameof(Club), request.Id);

            _context.Coaches.Remove(coach);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
