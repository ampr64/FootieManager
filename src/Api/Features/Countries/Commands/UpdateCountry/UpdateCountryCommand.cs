using MediatR;

namespace Api.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommand : IRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string FlagImageUrl { get; set; }
    }
}
