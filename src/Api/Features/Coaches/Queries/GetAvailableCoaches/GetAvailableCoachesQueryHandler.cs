using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Coaches.Queries.GetAvailableCoaches
{
    public class GetAvailableCoachesQueryHandler : ListQueryHandlerBase<GetAvailableCoachesQuery, Coach, CoachDto>
    {
        public GetAvailableCoachesQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override Task<IEnumerable<CoachDto>> Handle(GetAvailableCoachesQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Coaches.Where(c => c.ClubId == null)
                .OrderBy(c => c.FirstName)
                .ThenBy(c => c.LastName);

            return Handle(query, cancellationToken);
        }
    }
}
