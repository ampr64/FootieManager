using Core.Common;
using Core.Entities;
using Core.Enumerations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IPlayerService : IPersonService<Player>
    {
        Task<IReadOnlyList<Position>> ListAllPositions();

        Task<Player> GetHighestPaidPlayerInTheWorld();
    }
}
