using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Club : Entity<int>
    {
        public int LeagueId { get; set; }

        public League League { get; set; }

        public string Owner { get; set; }

        public int CoachId { get; set; }

        public Coach Coach { get; set; }

        public int TrophyCount { get; set; }

        public IList<Player> Squad { get; set; }
    }
}
