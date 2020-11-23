using MediatR;

namespace Api.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommand : IRequest
    {
        public int Id { get; set; }
    }
}
