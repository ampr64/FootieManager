using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Stadiums.Commands.UpdateStadium
{
    public class UpdateStadiumCommandHandler : UpdateCommandHandlerBase<UpdateStadiumCommand, Player>
    {
        public UpdateStadiumCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
