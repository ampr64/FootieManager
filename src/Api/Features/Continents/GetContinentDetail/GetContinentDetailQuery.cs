using Api.Common.Queries;

namespace Api.Features.Continents.GetContinentDetail
{
    public class GetContinentDetailQuery : DetailQuery<ContinentDto>
    {
        public GetContinentDetailQuery(int id)
            : base(id)
        {
        }
    }
}
