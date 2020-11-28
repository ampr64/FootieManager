using Api.Common.Queries;

namespace Api.Features.Coaches.Queries.GetCoachDetail
{
    public class GetCoachDetailQuery : DetailQuery<CoachDto>
    {
        public GetCoachDetailQuery(int id)
            : base(id)
        {
        }
    }
}
