using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Players.Queries.GetPlayerDetail
{
    public class GetPlayerDetailQueryHandler : GetDetailQueryHandlerBase<GetPlayerDetailQuery, Player, PlayerDto>
    {
        public GetPlayerDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
