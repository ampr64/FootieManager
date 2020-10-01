using Core.Common;
using Core.Entities;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IClubService : IEntityService<Club, int>
    {
        Task<int> GoalsFor();

        Task<int> GoalsAgainst(); 
    }
}
