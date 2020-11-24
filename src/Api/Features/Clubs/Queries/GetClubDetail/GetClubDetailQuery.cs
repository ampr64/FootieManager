using MediatR;

namespace Api.Features.Clubs.Queries.GetClubDetail
{
    public class GetClubDetailQuery : IRequest<ClubDto>
    {
        public int Id { get; set; }
    }
}
