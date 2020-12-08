using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Queries.GetClubDetail
{
    public class GetClubDetailQueryHandler : GetDetailQueryHandlerBase<GetClubDetailQuery, Club, ClubDetailDto>
    {
        public GetClubDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<ClubDetailDto> Handle(GetClubDetailQuery request, CancellationToken cancellationToken = default)
        {
            var clubDetail = await _context.Clubs.Include(c => c.Coach)
                .Include(c => c.Squad)
                .Include(c => c.Stadium)
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            return _mapper.Map<Club, ClubDetailDto>(clubDetail);
        }
    }
}
