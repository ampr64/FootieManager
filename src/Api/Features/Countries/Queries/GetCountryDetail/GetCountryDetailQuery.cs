using Api.Common.Queries;

namespace Api.Features.Countries.Queries.GetCountryDetail
{
    public class GetCountryDetailQuery : DetailQuery<CountryDto>
    {
        public GetCountryDetailQuery(int id)
            : base(id)
        {
        }
    }
}