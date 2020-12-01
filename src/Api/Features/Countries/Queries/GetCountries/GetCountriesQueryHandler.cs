using Api.Common.Queries;
using Api.Extensions;
using AutoMapper;
using Core.Common;
using Core.Entities;
using System.Collections.Generic;
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
            return await Handle(null, cancellationToken, (c => c.Name, SortDirection.Ascending));
        }
    }
}
