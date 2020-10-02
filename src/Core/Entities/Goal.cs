using Core.Common;
using Core.Enumerations;

namespace Core.Entities
{
    public class Goal : Entity<long>
    {
        public long MatchId { get; set; }

        public Player ScoredBy { get; set; }
        
        public Player AssistedBy { get; set; }

        public int Minute { get; set; }

        public GoalType Type { get; set; }
    }
}
