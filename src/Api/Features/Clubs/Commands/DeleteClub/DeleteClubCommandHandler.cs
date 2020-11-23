using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommandHandler : IRequestHandler<DeleteClubCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteClubCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(DeleteClubCommand request, CancellationToken cancellationToken)
        {
            var club = await _context.Clubs.FindAsync(request.Id);

            if (club is null)
                throw new NotFoundException(nameof(Club), request.Id);

            _context.Clubs.Remove(club);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
