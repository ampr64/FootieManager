using Core.Common;
using Core.Services;
using Domain.Common;
using Domain.Data;
using Domain.Entities;
using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PlayerService : PersonService<Player>, IPlayerService
    {
        public PlayerService(IUnitOfWork unitOfWork, IRepository<Player, int> repository)
            : base(unitOfWork, repository)
        {
        }

        public Task<IReadOnlyList<Position>> ListAllPositions()
        {
            var positions = Enumeration.GetAll<Position>();
            return Task.FromResult(positions);
        }
    }
}
