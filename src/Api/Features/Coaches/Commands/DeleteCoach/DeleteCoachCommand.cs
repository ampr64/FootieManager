using MediatR;

namespace Api.Features.Clubs.Commands.DeleteCoach
{
    public class DeleteCoachCommand : IRequest
    {
        public int Id { get; set; }
    }
}
