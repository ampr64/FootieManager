using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RefereeService : PersonService<Referee>, IRefereeService
    {
        public RefereeService(IUnitOfWork unitOfWork, IRefereeRepository repository)
            : base(unitOfWork, repository)
        {
        }
    }
}
