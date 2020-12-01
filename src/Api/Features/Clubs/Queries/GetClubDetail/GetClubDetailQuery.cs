using Api.Common.Queries;

namespace Api.Features.Clubs.Queries.GetClubDetail
{
    public class GetClubDetailQuery : DetailQuery<ClubDetailDto>
    {
        public GetClubDetailQuery(int id)
            : base(id)
        {
        }
    }
}
