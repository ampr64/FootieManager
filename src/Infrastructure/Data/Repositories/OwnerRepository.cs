using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class OwnerRepository : EfRepository<Owner, int>, IOwnerRepository
    {
        public OwnerRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
