using Api.Common.Queries;
using Api.Features.Leagues.Queries;
using Api.Features.Leagues.Queries.GetCountryLeagues;
using AutoMapper;
using Core.Common;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Countries.Queries.GetCountryClubs
{
    public class GetCountryLeaguesQueryHandler : ListQueryHandlerBase<GetCountryLeaguesQuery, League, LeagueDto>
    {
        public GetCountryLeaguesQueryHandler(IApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async override Task<IEnumerable<LeagueDto>> Handle(GetCountryLeaguesQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Leagues.Where(l => l.CountryId == request.CountryId)
                .OrderBy(l => l.Division);
            return await Handle(query, cancellationToken);
        }
    }
}
