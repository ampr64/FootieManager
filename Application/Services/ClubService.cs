using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClubService : ApplicationService<Club, int>, IClubService
    {
        public ClubService(IUnitOfWork unitOfWork, IClubRepository repository)
            : base(unitOfWork, repository)
        {
        }

        public Task<int> GoalsAgainst(int clubId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GoalsFor(int clubId)
        {
            throw new System.NotImplementedException();
        }
    }
}
