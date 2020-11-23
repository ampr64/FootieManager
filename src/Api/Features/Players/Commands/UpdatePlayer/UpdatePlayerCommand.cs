using MediatR;

namespace Api.Features.Players.Commands.UpdatePlayer
{
    public class UpdatePlayerCommand : PlayerWriteCommandBase<Unit>
    {
        public int Id { get; set; }
    }
}
