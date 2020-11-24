using MediatR;

namespace Api.Features.Stadiums.Commands.DeleteStadium
{
    public class DeleteStadiumCommand : IRequest
    {
        public int Id { get; set; }
    }
}
