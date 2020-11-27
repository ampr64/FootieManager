using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Clubs.Commands.NewClub
{
    public class NewClubCommandHandler : NewEntityCommandHandler<NewClubCommand, Club>
    {
        public NewClubCommandHandler(IApplicationDbContext context) :
            base(context)
        {
        }

        protected override Club CreateInstanceFromCommand(NewClubCommand request) => 
            new Club(
                request.Name,
                request.LeagueId,
                request.President,
                request.YearFounded,
                request.TrophyCount,
                request.StadiumId,
                request.CoachId,
                request.BadgeImageUrl);
    }
}
