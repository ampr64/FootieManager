using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;

namespace Application.Services
{
    public class CoachService : PersonService<Coach>, ICoachService
    {
        public CoachService(IUnitOfWork unitOfWork, ICoachRepository repository)
            : base(unitOfWork, repository)
        {
        }
    }
}
