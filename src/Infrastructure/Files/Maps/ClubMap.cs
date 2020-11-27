using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    internal sealed class ClubMap : ClassMap<Club>
    {
        internal ClubMap()
        {
            Map(m => m.Name).Name(nameof(Club.Name));
            Map(m => m.LeagueId).Name(nameof(Club.LeagueId));
            Map(m => m.President).Name(nameof(Club.President));
            Map(m => m.CoachId).Name(nameof(Club.CoachId));
            Map(m => m.StadiumId).Name(nameof(Club.StadiumId));
            Map(m => m.YearFounded).Name(nameof(Club.YearFounded));
            Map(m => m.TrophyCount).Name(nameof(Club.TrophyCount));
            Map(m => m.BadgeImageUrl).Name(nameof(Club.BadgeImageUrl));
        }
    }
}
