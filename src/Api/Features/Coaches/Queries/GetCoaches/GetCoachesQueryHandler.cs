using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Coaches.Queries.GetCoaches
{
    public class GetCoachesQueryHandler : ListQueryHandlerBase<GetCoachesQuery, Coach, CoachDto>
    {
        public GetCoachesQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
