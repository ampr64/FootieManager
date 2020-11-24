using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Leagues.Commands.NewLeague
{
    public class NewLeagueCommandHandler : IRequestHandler<NewLeagueCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public NewLeagueCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<int> Handle(NewLeagueCommand request, CancellationToken cancellationToken)
        {
            var league = new League(request.Name, request.CountryId, request.LogoImageUrl);

            await _context.Leagues.AddAsync(league, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return league.Id;
        }
    }
}
