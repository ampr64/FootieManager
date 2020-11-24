using Api.Extensions;
using AutoMapper;
using Core.Common;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Queries.GetClubs
{
    public class GetClubsQueryHandler : IRequestHandler<GetClubsQuery, GetClubsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetClubsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetClubsVm> Handle(GetClubsQuery request, CancellationToken cancellationToken)
        {
            return new GetClubsVm
            {
                Clubs = await _context.Clubs
                    .OrderBy(c => c.Name)
                    .ProjectToListAsync<ClubDto>(_mapper.ConfigurationProvider, cancellationToken)
            };
        }
    }
}
