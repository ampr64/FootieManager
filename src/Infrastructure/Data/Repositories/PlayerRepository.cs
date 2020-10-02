using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class PlayerRepository : EfRepository<Player, int>, IPlayerRepository
    {
        public PlayerRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
