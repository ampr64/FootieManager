using Api.Common.Queries;
using Api.Features.Players.Queries;
using Api.Features.Players.Queries.GetFreeAgents;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class GetFreeAgentsQueryHandler : ListQueryHandlerBase<GetFreeAgentsQuery, Player, PlayerDto>
    {
        public GetFreeAgentsQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override Task<IEnumerable<PlayerDto>> Handle(GetFreeAgentsQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Players.Where(p => p.ClubId == null)
                .OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            return Handle(query, cancellationToken);
        }
    }
}
