using MediatR;

namespace Api.Features.Leagues.Commands.NewLeague
{
    public class NewLeagueCommand : IRequest<int>
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public string LogoImageUrl { get; set; }
    }
}
