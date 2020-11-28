using Api.Common.Queries;

namespace Api.Features.Leagues.Queries.GetLeagueDetail
{
    public class GetLeagueDetailQuery : DetailQuery<LeagueDto>
    {
        public GetLeagueDetailQuery(int id)
            : base(id)
        {
        }
    }
}
