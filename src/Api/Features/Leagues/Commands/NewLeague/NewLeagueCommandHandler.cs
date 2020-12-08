using Api.Common.Commands;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
