using MediatR;

namespace Api.Features.Clubs.Commands.NewClub
{
    public class NewClubCommand : IRequest<int>
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public string Owner { get; set; }

        public int? CoachId { get; set; }

        public int StadiumId { get; set; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }
    }
}
