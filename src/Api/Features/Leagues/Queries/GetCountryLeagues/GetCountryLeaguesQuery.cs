using Api.Common.Queries;
using System.Collections.Generic;

namespace Api.Features.Leagues.Queries.GetCountryLeagues
{
    public class GetCountryLeaguesQuery : IQuery<IEnumerable<LeagueDto>>
    {
        public int CountryId { get; set; }

        public GetCountryLeaguesQuery(int countryId) => CountryId = countryId;
    }
}
