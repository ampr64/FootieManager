using Api.Common.Mappings;
using Api.Features.Coaches.Queries;
using Api.Features.Players.Queries;
using Api.Features.Stadiums.Queries;
using Core.Entities;
using System.Collections.Generic;

namespace Api.Features.Clubs.Queries
{
    public class ClubDetailDto : IDto<Club>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string President { get; set; }

        public StadiumDto Stadium { get; set; }

        public int LeagueId { get; set; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }

        public string BadgeImageUrl { get; set; }

        public int SquadCount { get; set; }

        public CoachDto Coach { get; set; }

        public List<PlayerDto> Squad { get; set; }
    }
}
