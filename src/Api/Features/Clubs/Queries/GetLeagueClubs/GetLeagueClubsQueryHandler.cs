using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Queries.GetLeagueClubs
{
    public class GetLeagueClubsQueryHandler : ListQueryHandlerBase<GetLeagueClubsQuery, Club, ClubDto>
    {
        public GetLeagueClubsQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<ClubDto>> Handle(GetLeagueClubsQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Clubs.Where(c => c.LeagueId == request.LeagueId)
                .OrderByDescending(c => c.TrophyCount)
                .ThenBy(c => c.Name);

            return await Handle(query, cancellationToken);
        }
    }
}
