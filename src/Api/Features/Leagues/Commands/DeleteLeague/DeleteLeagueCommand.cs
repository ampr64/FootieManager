using Api.Common.Commands;

namespace Api.Features.Leagues.Commands.DeleteLeague
{
    public class DeleteLeagueCommand : DeleteCommand
    {
        public DeleteLeagueCommand(int id)
            : base(id)
        {
        }
    }
}
