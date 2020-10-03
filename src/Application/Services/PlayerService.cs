using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
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

        public async Task<Player> GetHighestPaidPlayerInTheWorldAsync()
        {
            var players = await _repository.ListAllAsync();
            return players.OrderByDescending(p => p.YearlySalary)
                .FirstOrDefault();
        }
    }
}
