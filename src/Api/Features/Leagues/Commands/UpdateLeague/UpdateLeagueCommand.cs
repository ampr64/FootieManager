using MediatR;

namespace Api.Features.Leagues.Commands.UpdateLeague
{
    public class UpdateLeagueCommand : IRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public string LogoImageUrl { get; set; }
    }
}
