using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Clubs.Queries.GetClubDetail
{
    public class GetClubDetailQueryHandler : GetEntityDetailQueryHandler<GetClubDetailQuery, Club, ClubDto>
    {
        public GetClubDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
