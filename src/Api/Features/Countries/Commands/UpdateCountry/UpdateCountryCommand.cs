using Api.Common.Commands;

namespace Api.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommand : EntityCommand
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string FlagImageUrl { get; set; }
    }
}
