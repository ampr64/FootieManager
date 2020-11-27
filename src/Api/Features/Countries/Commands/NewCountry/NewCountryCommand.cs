using Api.Common.Commands;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommand : ICommand<int>
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string FlagImageUrl { get; set; }
    }
}
