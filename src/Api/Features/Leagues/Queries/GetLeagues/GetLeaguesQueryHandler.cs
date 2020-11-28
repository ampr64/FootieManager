using Api.Common.Queries;
using Api.Extensions;
using AutoMapper;
using Core.Common;
using Core.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Leagues.Queries.GetLeagues
{
    public class GetLeaguesQueryHandler : ListQueryHandlerBase<GetLeaguesQuery, League, LeagueDto>
    {
        public GetLeaguesQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override Task<IEnumerable<LeagueDto>> Handle(GetLeaguesQuery request, CancellationToken cancellationToken)
        {
            return Handle(null, cancellationToken, (l => l.CountryId, SortDirection.Ascending), (l => l.Division, SortDirection.Ascending));
        }
    }
}
