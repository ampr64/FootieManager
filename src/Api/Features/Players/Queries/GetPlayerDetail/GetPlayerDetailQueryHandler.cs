using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
