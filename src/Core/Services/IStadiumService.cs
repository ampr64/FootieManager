using Core.Common;
using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IStadiumService : IService<Stadium, int>
    {
        Task<Stadium> GetStadiumWithHighestCapacityInTheWorld();

        Task<Stadium> GetStadiumWithHighestCapacityInContinent(int continentId);

        Task<Stadium> GetStadiumWithHighestCapacityInCountry(int countryId);

        Task<Stadium> GetStadiumWithHighestCapacityInLeague(int leagueId);

        Task<IReadOnlyList<Stadium>> GetTopHighestCapacityStadiums(int topCount);
    }
}
