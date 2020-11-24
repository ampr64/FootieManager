using Api.Configuration.Mappings;
using Core.Entities;

namespace Api.Features.Clubs.Queries
{
    public class ClubDto : IDto<Club>
    {
        public string Name { get; set; }

        public string Owner { get; set; }

        public int? CoachId { get; set; }

        public int StadiumId { get; set; }

        public int LeagueId { get; set; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }

        public string BadgeUrl { get; set; }
    }
}
