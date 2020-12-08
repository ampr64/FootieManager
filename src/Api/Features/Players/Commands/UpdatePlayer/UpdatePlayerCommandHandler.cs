using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
