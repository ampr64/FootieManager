using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Leagues.Commands.DeleteLeague
{
    public class DeleteLeagueCommandHandler : IRequestHandler<DeleteLeagueCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteLeagueCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(DeleteLeagueCommand request, CancellationToken cancellationToken)
        {
            var league = await _context.Leagues.FindAsync(request.Id, cancellationToken);

            if (league is null)
                throw new NotFoundException(nameof(League), request.Id);

            _context.Leagues.Remove(league);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
