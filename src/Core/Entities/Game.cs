using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Game : Entity<long>
    {
        public Club Home { get; set; }

        public Club Away { get; set; }

        public IList<Player> HomeLineup { get; set; }

        public IList<Player> AwayLineup { get; set; }

        public IList<Goal> HomeGoals { get; set; }

        public IList<Goal> AwayGoals { get; set; }

        public Stadium Stadium { get; set; }

        public Referee Referee { get; set; }
    }
}
