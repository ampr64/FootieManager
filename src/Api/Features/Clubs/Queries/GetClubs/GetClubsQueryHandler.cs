using Api.Common.Queries;
using Api.Extensions;
using AutoMapper;
using Core.Common;
using Core.Entities;
using System.Collections.Generic;
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
            return await Handle(null, cancellationToken, (c => c.LeagueId, SortDirection.Ascending), (c => c.Name, SortDirection.Ascending));
        }
    }
}
