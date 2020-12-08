using Api.Common.Queries;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Countries.Queries.GetCountries
{
    public class GetCountriesQueryHandler : ListQueryHandlerBase<GetCountriesQuery, Country, CountryDto>
    {
        public GetCountriesQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<CountryDto>> Handle(GetCountriesQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Countries.OrderBy(c => c.Name);
            return await Handle(query, cancellationToken);
        }
    }
}
