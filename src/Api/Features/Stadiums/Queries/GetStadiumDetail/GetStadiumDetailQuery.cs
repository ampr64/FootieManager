using Api.Common.Queries;

namespace Api.Features.Stadiums.Queries.GetStadiumDetail
{
    public class GetStadiumDetailQuery : DetailQuery<StadiumDto>
    {
        public GetStadiumDetailQuery(int id)
            : base(id)
        {
        }
    }
}
