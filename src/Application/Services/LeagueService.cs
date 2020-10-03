using Application.Common;
using Core.Common;
using Core.Data;
using Core.Entities;
using Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class LeagueService : ApplicationService<League, int>, ILeagueService
    {
        public LeagueService(IUnitOfWork unitOfWork, ILeagueRepository repository)
            : base(unitOfWork, repository)
        {
        }

        public Task<IReadOnlyList<Club>> GetClubs(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Club> GetClubWithHighestAgeAverage(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Club> GetClubWithLowestAgeAverage(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Club> GetClubWithMostGoalsAgainst(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Club> GetClubWithMostGoalsFor(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Player> GetOldestPlayer(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Player> GetTopAssister(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Player> GetTopScorer(int leagueId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Player> GetYoungestPlayer(int leagueId)
        {
            throw new System.NotImplementedException();
        }
    }
}
