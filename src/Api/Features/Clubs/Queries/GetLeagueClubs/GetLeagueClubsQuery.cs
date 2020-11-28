using Api.Common.Queries;
using System.Collections.Generic;

namespace Api.Features.Clubs.Queries.GetLeagueClubs
{
    public class GetLeagueClubsQuery : IQuery<IEnumerable<ClubDto>>
    {
        public int LeagueId { get; set; }
    }
}
