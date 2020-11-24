using MediatR;

namespace Api.Features.Leagues.Commands.DeleteLeague
{
    public class DeleteLeagueCommand : IRequest
    {
        public int Id { get; set; }
    }
}
