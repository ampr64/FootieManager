using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class ClubRepository : EfRepository<Club, int>, IClubRepository
    {
        public ClubRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
