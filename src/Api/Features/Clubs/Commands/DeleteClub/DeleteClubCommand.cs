using Api.Common.Commands;

namespace Api.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommand : DeleteCommand
    {
        public DeleteClubCommand(int id)
            : base(id)
        {
        }
    }
}
