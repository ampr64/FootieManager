using Api.Common.Queries;
using Api.Extensions;
using AutoMapper;
using Core.Common;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Players.Queries.GetClubPlayers
{
    public class GetClubPlayersQueryHandler : ListQueryHandlerBase<GetClubPlayersQuery, Player, PlayerDto>
    {
        public GetClubPlayersQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override Task<IEnumerable<PlayerDto>> Handle(GetClubPlayersQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Players.Where(p => p.ClubId == request.ClubId);

            return Handle(query, cancellationToken, (p => p.PositionId, SortDirection.Ascending), (p => p.LastName, SortDirection.Ascending));
        }
    }
}
