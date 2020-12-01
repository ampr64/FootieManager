using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    public sealed class CoachMap : ClassMap<Coach>
    {
        public CoachMap(CsvConfiguration configuration)
        {
            AutoMap(configuration);
        }
    }
}
