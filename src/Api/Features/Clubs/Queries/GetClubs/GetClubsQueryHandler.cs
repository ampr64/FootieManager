using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Queries.GetClubs
{
    public class GetClubsQueryHandler : ListQueryHandlerBase<GetClubsQuery, Club, ClubDto>
    {
        public GetClubsQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<ClubDto>> Handle(GetClubsQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Clubs.OrderBy(c => c.LeagueId)
                .ThenBy(c => c.Name);

            return await Handle(query, cancellationToken);
        }
    }
}
