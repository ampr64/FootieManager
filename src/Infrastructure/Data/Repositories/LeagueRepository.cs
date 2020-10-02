using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class LeagueRepository : EfRepository<League, int>, ILeagueRepository
    {
        public LeagueRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
