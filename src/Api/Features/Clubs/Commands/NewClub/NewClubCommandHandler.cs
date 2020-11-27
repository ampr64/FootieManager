using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Commands.NewClub
{
    public class NewClubCommandHandler : IRequestHandler<NewClubCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public NewClubCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<int> Handle(NewClubCommand request, CancellationToken cancellationToken)
        {
            var newClub = new Club(
                request.Name,
                request.LeagueId,
                request.President,
                request.YearFounded,
                request.TrophyCount,
                request.StadiumId,
                request.CoachId,
                request.BadgeImageUrl);

            await _context.Clubs.AddAsync(newClub, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return newClub.Id;
        }
    }
}
