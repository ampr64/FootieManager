using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Stadiums.Queries.GetStadiumDetail
{
    public class GetStadiumDetailQueryHandler : GetDetailQueryHandlerBase<GetStadiumDetailQuery, Stadium, StadiumDto>
    {
        public GetStadiumDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
