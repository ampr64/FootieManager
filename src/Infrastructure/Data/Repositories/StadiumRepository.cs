using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class StadiumRepository : EfRepository<Stadium, int>, IStadiumRepository
    {
        public StadiumRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
