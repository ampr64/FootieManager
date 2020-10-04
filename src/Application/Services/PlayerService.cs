using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PlayerService : PersonService<Player>, IPlayerService
    {
        private readonly Expression<Func<Player, object>> _includeClub = p => p.Club;
        private readonly Expression<Func<Player, object>> _includeCountry = p => p.Country;

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

        public override Task<Player> GetByIdAsync(int id)
        {
            return GetByIdAsync(id,
                _includeClub,
                _includeCountry);
        }

        public override Task<IReadOnlyList<Player>> GetAllAsync()
        {
            return base.GetAllAsync(
                "Club," +
                "Country");
        }
    }
}
