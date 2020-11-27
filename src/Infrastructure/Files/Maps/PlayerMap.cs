using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    internal sealed class PlayerMap : ClassMap<Player>
    {
        internal PlayerMap(CsvConfiguration configuration)
        {
            AutoMap(configuration);
            Map(m => m.PictureUrl).Name(nameof(Player.PictureUrl));
        }
    }
}
