using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Club : Entity<int>
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public League League { get; set; }

        public string Chairman { get; set; }

        public int? CoachId { get; set; }

        public Coach Coach { get; set; }

        public int? StadiumId { get; set; }

        public Stadium Stadium { get; set; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }

        public IList<Player> Squad { get; set; }

        public Club() { }

        public Club(string name, int leagueId, string chairman, int yearFounded, int trophyCount, int? stadiumId, int? coachId)
        {
            Name = name;
            LeagueId = leagueId;
            Chairman = chairman;
            CoachId = coachId;
            YearFounded = yearFounded;
            TrophyCount = trophyCount;
            StadiumId = stadiumId;
            CoachId = coachId;
        }
    }
}
