using Core.Entities;

namespace Infrastructure.Files.Maps
{
    internal sealed class LeagueMap : AbstractMap<League>
    {
        internal LeagueMap()
        {
            MapWithNameConvention(m => m.Name);
            MapWithNameConvention(m => m.CountryId);
            MapWithNameConvention(m => m.Division);
            MapWithNameConvention(m => m.LogoImageUrl);
        }
    }
}
