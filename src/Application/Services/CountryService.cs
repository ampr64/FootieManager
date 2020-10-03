using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CountryService : ApplicationService<Country, int>, ICountryService
    {
        public CountryService(IUnitOfWork unitOfWork, ICountryRepository repository)
            : base(unitOfWork, repository)
        {
        }
    }
}
