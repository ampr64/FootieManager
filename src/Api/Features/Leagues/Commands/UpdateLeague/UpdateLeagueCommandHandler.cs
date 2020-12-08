using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Leagues.Commands.UpdateLeague
{
    public class UpdateLeagueCommandHandler : UpdateCommandHandlerBase<UpdateLeagueCommand, League>
    {
        public UpdateLeagueCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
