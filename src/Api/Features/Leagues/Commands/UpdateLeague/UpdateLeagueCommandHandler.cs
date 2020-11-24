using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Leagues.Commands.UpdateLeague
{
    public class UpdateLeagueCommandHandler : IRequestHandler<UpdateLeagueCommand>
    {
        private readonly IApplicationDbContext _context;

        public IApplicationDbContext Context => _context;

        public async Task<Unit> Handle(UpdateLeagueCommand request, CancellationToken cancellationToken)
        {
            var league = await _context.Leagues.FindAsync(request.Id, cancellationToken);

            if (league is null)
                throw new NotFoundException(nameof(League), request.Id);

            league.Name = request.Name;
            league.CountryId = request.CountryId;
            league.Division = request.Division;
            league.LogoImageUrl = request.LogoImageUrl;

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
