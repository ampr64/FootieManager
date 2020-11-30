using Api.Common.Commands;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Leagues.Commands.NewLeague
{
    public class NewLeagueCommandHandler : NewCommandHandlerBase<NewLeagueCommand, League>
    {
        public NewLeagueCommandHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
