using Api.Common.Commands;

namespace Api.Features.Clubs.Commands.DeletePlayer
{
    public class DeletePlayerCommand : DeleteCommand
    {
        public DeletePlayerCommand(int id)
            : base(id)
        {
        }
    }
}
