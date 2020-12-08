using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Stadiums.Queries.GetStadiums
{
    public class GetStadiumsQueryHandler : ListQueryHandlerBase<GetStadiumsQuery, Stadium, StadiumDto>
    {
        public GetStadiumsQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
