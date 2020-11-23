using MediatR;

namespace Api.Features.Clubs.Commands.UpdateClub
{
    public class UpdateClubCommand : IRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LeagueId { get; set; }

        public string Owner { get; set; }

        public int? CoachId { get; set; }

        public int StadiumId { get; set; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }
    }
}
