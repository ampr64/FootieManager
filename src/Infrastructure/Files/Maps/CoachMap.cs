using Core.Entities;

namespace Infrastructure.Files.Maps
{
    internal sealed class CoachMap : AbstractMap<Coach>
    {
        internal CoachMap()
        {
            MapWithNameConvention(m => m.FirstName);
            MapWithNameConvention(m => m.LastName);
            MapWithNameConvention(m => m.CountryId);
            MapWithNameConvention(m => m.BirthDate);
            MapWithNameConvention(m => m.PictureUrl);
            MapWithNameConvention(m => m.ClubId);
            MapWithNameConvention(m => m.Salary);
        }
    }
}
