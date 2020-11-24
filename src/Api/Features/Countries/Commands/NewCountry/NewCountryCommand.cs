using MediatR;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommand : IRequest<int>
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string FlagImageUrl { get; set; }
    }
}
