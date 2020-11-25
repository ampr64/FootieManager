using Core.Entities;

namespace Infrastructure.Files.Maps
{
    internal class StadiumMap : AbstractMap<Stadium>
    {
        internal StadiumMap()
        {
            MapWithNameConvention(m => m.Name);
            MapWithNameConvention(m => m.Capacity);
            MapWithNameConvention(m => m.YearBuilt);
        }
    }
}
