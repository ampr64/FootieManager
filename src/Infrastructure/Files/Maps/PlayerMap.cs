using Core.Entities;

namespace Infrastructure.Files.Maps
{
    internal sealed class PlayerMap : AbstractMap<Player>
    {
        internal PlayerMap()
        {
            MapWithNameConvention(m => m.FirstName);
            MapWithNameConvention(m => m.LastName);
            MapWithNameConvention(m => m.CountryId);
            MapWithNameConvention(m => m.BirthDate);
            MapWithNameConvention(m => m.Height);
            MapWithNameConvention(m => m.Weight);
            MapWithNameConvention(m => m.MarketValue);
            MapWithNameConvention(m => m.PositionId);
            MapWithNameConvention(m => m.PictureUrl);
            MapWithNameConvention(m => m.Foot);
            MapWithNameConvention(m => m.ClubId);
            MapWithNameConvention(m => m.Salary);
        }
    }
}
