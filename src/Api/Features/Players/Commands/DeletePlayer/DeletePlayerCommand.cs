using MediatR;

namespace Api.Features.Clubs.Commands.DeletePlayer
{
    public class DeletePlayerCommand : IRequest
    {
        public int Id { get; set; }
    }
}
