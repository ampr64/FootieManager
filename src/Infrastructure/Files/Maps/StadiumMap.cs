using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    public sealed class StadiumMap : ClassMap<Stadium>
    {
        public StadiumMap(CsvConfiguration configuration)
        {
        }
    }
}
