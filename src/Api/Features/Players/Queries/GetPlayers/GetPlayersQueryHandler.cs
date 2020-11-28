using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Players.Queries.GetPlayers
{
    public class GetPlayersQueryHandler : ListQueryHandlerBase<GetPlayersQuery, Player, PlayerDto>
    {
        public GetPlayersQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
