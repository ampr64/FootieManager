using Api.Common.Mappings;
using Core.Entities;

namespace Api.Features.Leagues.Queries
{
    public class LeagueDto : IDto<League>
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public int Division { get; set; }

        public string LogoImageUrl { get; set; }
    }
}
