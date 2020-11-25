using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Data.Seed
{
    public static class ClubSeedData
    {
        public static IEnumerable<Club> Clubs
        {
            get => new List<Club>
            {
                new Club("FC Barcelona", 3, "Josep Maria Bartomeu", 1899, 74, 7, null, ""),
                new Club("Liverpool FC", 4, "Tom Werner", 1892, 47, 3)
            };
        }
    }
}
