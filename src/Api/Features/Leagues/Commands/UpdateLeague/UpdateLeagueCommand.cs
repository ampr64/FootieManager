using Api.Common.Commands;

namespace Api.Features.Leagues.Commands.UpdateLeague
{
    public class UpdateLeagueCommand : EntityCommand
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public int Division { get; set; }

        public string LogoImageUrl { get; set; }
    }
}
