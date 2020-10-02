using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class CoachRepository : EfRepository<Coach, int>, ICoachRepository
    {
        public CoachRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
