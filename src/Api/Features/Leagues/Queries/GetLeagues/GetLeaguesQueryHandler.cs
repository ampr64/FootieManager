using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
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
            var query = _context.Leagues.OrderBy(l => l.CountryId)
                .ThenBy(l => l.Division);

            return Handle(query, cancellationToken);
        }
    }
}
