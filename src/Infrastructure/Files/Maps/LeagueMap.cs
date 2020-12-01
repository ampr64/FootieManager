using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    public sealed class LeagueMap : ClassMap<League>
    {
        public LeagueMap(CsvConfiguration configuration)
        {
            AutoMap(configuration);
        }
    }
}
