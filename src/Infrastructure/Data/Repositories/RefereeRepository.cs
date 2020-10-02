using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RefereeRepository : EfRepository<Referee, int>, IRefereeRepository
    {
        public RefereeRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
