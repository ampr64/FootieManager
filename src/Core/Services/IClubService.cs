using Core.Common;
using Core.Entities;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IClubService : IService<Club, int>
    {
        Task<int> GoalsFor(int clubId);

        Task<int> GoalsAgainst(int clubId); 
    }
}
