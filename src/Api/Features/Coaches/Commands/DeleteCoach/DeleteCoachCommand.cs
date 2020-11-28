using Api.Common.Commands;

namespace Api.Features.Clubs.Commands.DeleteCoach
{
    public class DeleteCoachCommand : DeleteCommand
    {
        public DeleteCoachCommand(int id)
            : base(id)
        {
        }
    }
}
