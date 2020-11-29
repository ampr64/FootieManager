using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Leagues.Queries.GetLeagueDetail
{
    public class GetLeagueDetailQueryHandler : GetDetailQueryHandlerBase<GetLeagueDetailQuery, League, LeagueDto>
    {
        public GetLeagueDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
