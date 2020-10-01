using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Enumerations;
using Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PlayerService : PersonService<Player>, IPlayerService
    {
        public PlayerService(IUnitOfWork unitOfWork, IPlayerRepository repository)
            : base(unitOfWork, repository)
        {
        }

        public async Task<Player> GetHighestPaidPlayerInTheWorld()
        {
            var players = await _repository.ListAllAsync();
            return players.OrderBy(p => p.Salary).Take(1)
                .SingleOrDefault();
        }

        public Task<IReadOnlyList<Position>> ListAllPositions()
        {
            var positions = Enumeration.GetAll<Position>();
            return Task.FromResult(positions);
        }
    }
}
