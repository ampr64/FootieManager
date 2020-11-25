using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Club : Entity
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public League League { get; set; }

        public string Owner { get; set; }

        public int? CoachId { get; set; }

        public Coach Coach { get; set; }

        public int? StadiumId { get; set; }

        public Stadium Stadium { get; set; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }

        public string BadgeImageUrl { get; set; }

        public List<Player> Squad { get; set; } = new();

        public Club() { }

        public Club(
            string name,
            int leagueId,
            string owner,
            int yearFounded,
            int trophyCount,
            int stadiumId,
            int? coachId = null,
            string badgeImageUrl = null)
        {
            Name = name;
            LeagueId = leagueId;
            Owner = owner;
            CoachId = coachId;
            YearFounded = yearFounded;
            TrophyCount = trophyCount;
            StadiumId = stadiumId;
            CoachId = coachId;
            BadgeImageUrl = badgeImageUrl;
        }
    }
}
