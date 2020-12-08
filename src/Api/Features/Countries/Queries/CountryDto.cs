using Api.Common.Mappings;
using ApplicationCore.Entities;

namespace Api.Features.Countries.Queries
{
    public class CountryDto : IDto<Country>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string FlagImageUrl { get; set; }
    }
}
