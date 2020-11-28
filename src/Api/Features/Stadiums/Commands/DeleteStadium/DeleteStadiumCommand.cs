using Api.Common.Commands;

namespace Api.Features.Stadiums.Commands.DeleteStadium
{
    public class DeleteStadiumCommand : DeleteCommand
    {
        public DeleteStadiumCommand(int id)
            : base(id)
        {
        }
    }
}
