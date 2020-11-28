using Api.Common.Queries;

namespace Api.Features.Players.Queries.GetPlayerDetail
{
    public class GetPlayerDetailQuery : DetailQuery<PlayerDto>
    {
        public GetPlayerDetailQuery(int id)
            : base(id)
        {
        }
    }
}
