using ApplicationCore.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    public sealed class ClubMap : ClassMap<Club>
    {
        public ClubMap(CsvConfiguration configuration)
        {
            AutoMap(configuration);
        }
    }
}
