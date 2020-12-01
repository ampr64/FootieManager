using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    public sealed class PlayerMap : ClassMap<Player>
    {
        public PlayerMap(CsvConfiguration configuration)
        {
            AutoMap(configuration);
        }
    }
}
