using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
