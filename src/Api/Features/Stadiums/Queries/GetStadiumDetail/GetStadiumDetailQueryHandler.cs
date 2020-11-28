using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

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
