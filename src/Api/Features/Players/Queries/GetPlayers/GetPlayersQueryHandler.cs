using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
