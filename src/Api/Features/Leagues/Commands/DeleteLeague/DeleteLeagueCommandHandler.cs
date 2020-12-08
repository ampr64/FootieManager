using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Leagues.Commands.DeleteLeague
{
    public class DeleteLeagueCommandHandler : DeleteCommandHandlerBase<DeleteLeagueCommand, League>
    {
        public DeleteLeagueCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
