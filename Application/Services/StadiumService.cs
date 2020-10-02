using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StadiumService : ApplicationService<Stadium, int>, IStadiumService
    {
        public StadiumService(IUnitOfWork unitOfWork, IStadiumRepository repository)
            : base(unitOfWork, repository)
        {
        }

        public Task<Stadium> GetStadiumWithHighestCapacityInContinent(int continentId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Stadium> GetStadiumWithHighestCapacityInCountry(int countryId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Stadium> GetStadiumWithHighestCapacityInLeague(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Stadium> GetStadiumWithHighestCapacityInTheWorld()
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Stadium>> GetTopHighestCapacityStadiums(int topCount)
        {
            throw new System.NotImplementedException();
        }
    }
}
