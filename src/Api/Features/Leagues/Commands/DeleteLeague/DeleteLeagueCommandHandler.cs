using Api.Common.Commands;
using Core.Common;
using Core.Entities;

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
