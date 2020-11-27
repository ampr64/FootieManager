using Api.Common.Commands;
using Core.Common;
using Core.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Leagues.Commands.NewLeague
{
    public class NewLeagueCommandHandler : NewEntityCommandHandler<NewLeagueCommand, League>
    {
        public NewLeagueCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }

        protected override League CreateInstanceFromCommand(NewLeagueCommand request) =>
            new League(
                request.Name,
                request.CountryId,
                request.Division,
                request.LogoImageUrl);
    }
}
