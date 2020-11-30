using Api.Common.Commands;
using Api.Common.Mappings;
using Core.Entities;

namespace Api.Features.Leagues.Commands.NewLeague
{
    public class NewLeagueCommand : ICommand<int>, ICommandMap<League>
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public int Division { get; set; }

        public string LogoImageUrl { get; set; }
    }
}
