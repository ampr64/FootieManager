using Api.Common.Commands;
using Api.Common.Mappings;
using ApplicationCore.Entities;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommand : ICommand<int>, ICommandMap<Country>
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string IsoCode { get; set; }

        public string FlagImageUrl { get; set; }
    }
}
