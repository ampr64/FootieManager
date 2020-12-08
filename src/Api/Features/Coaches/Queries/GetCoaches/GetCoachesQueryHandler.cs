using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
