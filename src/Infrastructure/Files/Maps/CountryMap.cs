using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    internal sealed class CountryMap : ClassMap<Country>
    {
        internal CountryMap()
        {
            Map(m => m.Name).Name(nameof(Country.Name));
            Map(m => m.ContinentId).Name(nameof(Country.ContinentId));
            Map(m => m.FlagImageUrl).Name(nameof(Country.FlagImageUrl));
        }
    }
}
