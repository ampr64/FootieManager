using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class ContinentRepository : EfRepository<Continent, int>, IContinentRepository
    {
        public ContinentRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
