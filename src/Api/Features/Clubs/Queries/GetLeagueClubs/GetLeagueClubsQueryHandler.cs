using Api.Common.Queries;
using Api.Extensions;
using AutoMapper;
using Core.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Queries.GetLeagueClubs
{
    public class GetLeagueClubsQueryHandler : IQueryHandler<GetLeagueClubsQuery, IEnumerable<ClubDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetLeagueClubsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClubDto>> Handle(GetLeagueClubsQuery request, CancellationToken cancellationToken) =>
            await _context.Clubs
                .Where(c => c.LeagueId == request.LeagueId)
                .OrderBy(c => c.Name)
                .ProjectToListAsync<ClubDto>(_mapper.ConfigurationProvider, cancellationToken);
    }
}
