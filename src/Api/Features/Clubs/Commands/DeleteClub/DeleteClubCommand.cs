using Api.Common.Commands;

namespace Api.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommand : EntityCommand
    {
        public DeleteClubCommand(int id) => Id = id;
    }
}
