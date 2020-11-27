using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    internal sealed class LeagueMap : ClassMap<League>
    {
        internal LeagueMap(CsvConfiguration configuration)
        {
            AutoMap(configuration);
            Map(m => m.LogoImageUrl).Name(nameof(League.LogoImageUrl));
        }
    }
}
