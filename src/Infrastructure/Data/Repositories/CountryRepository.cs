using Core.Data;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class CountryRepository : EfRepository<Country, int>, ICountryRepository
    {
        public CountryRepository(FootieDataManagerContext context)
            : base(context)
        {
        }
    }
}
