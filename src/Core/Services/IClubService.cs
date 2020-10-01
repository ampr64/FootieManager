using Core.Entities;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IClubService : IService<Club, int>
    {
        Task<int> GoalsFor();

        Task<int> GoalsAgainst(); 
    }
}
