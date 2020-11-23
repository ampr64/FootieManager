using Api.Exceptions;
using Api.Features.Clubs.Commands.UpdateClub;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Commands.UpdateClubDetails
{
    public class UpdateClubCommandHandler : IRequestHandler<UpdateClubCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateClubCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(UpdateClubCommand request, CancellationToken cancellationToken)
        {
            var club = await _context.Clubs.FindAsync(request.Id, cancellationToken);

            if (club is null)
                throw new NotFoundException(nameof(Club), request.Id);

            club.Name = request.Name;
            club.CoachId = request.CoachId;
            club.LeagueId = request.LeagueId;
            club.Owner = request.Owner;
            club.StadiumId = request.StadiumId;
            club.TrophyCount = request.TrophyCount;
            club.YearFounded = request.YearFounded;

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
