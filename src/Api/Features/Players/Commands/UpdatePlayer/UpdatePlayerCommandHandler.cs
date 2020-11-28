using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Players.Commands.UpdatePlayer
{
    public class UpdatePlayerCommandHandler : UpdateCommandHandlerBase<UpdatePlayerCommand, Player>
    {
        public UpdatePlayerCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
