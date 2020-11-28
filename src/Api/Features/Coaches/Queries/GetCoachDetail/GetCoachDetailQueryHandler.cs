using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Coaches.Queries.GetCoachDetail
{
    public class GetCoachDetailQueryHandler : GetDetailQueryHandlerBase<GetCoachDetailQuery, Coach, CoachDto>
    {
        public GetCoachDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
