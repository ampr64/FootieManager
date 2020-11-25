using Core.Entities;

namespace Infrastructure.Files.Maps
{
    internal sealed class CountryMap : AbstractMap<Country>
    {
        internal CountryMap()
        {
            MapWithNameConvention(m => m.Name);
            MapWithNameConvention(m => m.ContinentId);
            MapWithNameConvention(m => m.FlagImageUrl);
        }
    }
}
