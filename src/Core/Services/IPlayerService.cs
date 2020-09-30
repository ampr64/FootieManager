using Domain.Entities;
using Domain.Enumerations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IPlayerService : IPersonService<Player>
    {
        Task<IReadOnlyList<Position>> ListAllPositions();
    }
}
