using ApplicationCore.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    public sealed class CountryMap : ClassMap<Country>
    {
        public CountryMap(CsvConfiguration configuration)
        {
            AutoMap(configuration);
        }
    }
}
