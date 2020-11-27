using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    internal class StadiumMap : ClassMap<Stadium>
    {
        internal StadiumMap()
        {
            Map(m => m.Name).Name(nameof(Stadium.Name));
            Map(m => m.Capacity).Name(nameof(Stadium.Capacity));
            Map(m => m.YearBuilt).Name(nameof(Stadium.YearBuilt));
        }
    }
}
