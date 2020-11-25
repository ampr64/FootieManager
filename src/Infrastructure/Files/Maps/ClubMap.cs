using Core.Entities;

namespace Infrastructure.Files.Maps
{
    internal sealed class ClubMap : AbstractMap<Club>
    {
        internal ClubMap()
        {
            MapWithNameConvention(m => m.Name);
            MapWithNameConvention(m => m.LeagueId);
            MapWithNameConvention(m => m.Owner);
            MapWithNameConvention(m => m.CoachId);
            MapWithNameConvention(m => m.YearFounded);
            MapWithNameConvention(m => m.TrophyCount);
            MapWithNameConvention(m => m.StadiumId);
            MapWithNameConvention(m => m.CoachId);
            MapWithNameConvention(m => m.BadgeImageUrl);
        }
    }
}
