using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ContinentService : ApplicationService<Continent, int>, IContinentService
    {
        public ContinentService(IUnitOfWork unitOfWork, IContinentRepository repository)
            : base(unitOfWork, repository)
        {
        }
    }
}
