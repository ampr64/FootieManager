using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Fixture : Entity
    {
        public int HomeId { get; set; }

        public Club Home { get; set; }

        public int AwayId { get; set; }

        public Club Away { get; set; }

        public List<Player> HomeLineup { get; set; } = new();

        public List<Player> AwayLineup { get; set; } = new();

        public List<Goal> HomeGoals { get; set; } = new();

        public List<Goal> AwayGoals { get; set; } = new();

        public Stadium Stadium { get; set; }

        public Referee Referee { get; set; }
    }
}
