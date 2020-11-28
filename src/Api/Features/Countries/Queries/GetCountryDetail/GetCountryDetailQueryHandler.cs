using Api.Common.Queries;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Countries.Queries.GetCountryDetail
{
    public class GetCountryDetailQueryHandler : GetDetailQueryHandlerBase<GetCountryDetailQuery, Country, CountryDto>
    {
        public GetCountryDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
