using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
