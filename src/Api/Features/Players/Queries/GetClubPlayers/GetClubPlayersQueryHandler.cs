using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
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
            var query = _context.Players.Where(p => p.ClubId == request.ClubId)
                .OrderBy(p => p.Position)
                .ThenBy(p => p.FirstName)
                .ThenBy(p => p.LastName);

            return Handle(query, cancellationToken);
        }
    }
}
