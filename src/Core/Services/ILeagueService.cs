using Core.Common;
using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ILeagueService : IService<League, int>
    {
        Task<Player> GetTopScorer(int leagueId);

        Task<Player> GetTopAssister(int leagueId);

        Task<Player> GetOldestPlayer(int leagueId);

        Task<Player> GetYoungestPlayer(int leagueId);

        Task<Club> GetClubWithMostGoalsFor(int leagueId);

        Task<Club> GetClubWithMostGoalsAgainst(int leagueId);

        Task<Club> GetClubWithHighestAgeAverage(int leagueId);

        Task<Club> GetClubWithLowestAgeAverage(int leagueId);

        Task<IReadOnlyList<Club>> GetClubs(int leagueId);
    }
}
