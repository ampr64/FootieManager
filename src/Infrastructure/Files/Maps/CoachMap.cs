using Core.Entities;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps
{
    internal sealed class CoachMap : ClassMap<Coach>
    {
        internal CoachMap()
        {
            Map(m => m.FirstName).Name(nameof(Coach.FirstName));
            Map(m => m.LastName).Name(nameof(Coach.LastName));
            Map(m => m.CountryId).Name(nameof(Coach.CountryId));
            Map(m => m.BirthDate).Name(nameof(Coach.BirthDate));
            Map(m => m.PictureUrl).Name(nameof(Coach.PictureUrl));
            Map(m => m.ClubId).Name(nameof(Coach.ClubId));
            Map(m => m.Salary).Name(nameof(Coach.Salary));
        }
    }
}
