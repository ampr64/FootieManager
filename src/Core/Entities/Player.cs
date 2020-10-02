using Core.Common;
using Core.Enumerations;
using System;

namespace Core.Entities
{
    public class Player : Person
    {
        public int ClubId { get; set; }

        public Club Club { get; set; }

        public int PositionId { get; set; }

        public Position Position { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public decimal Salary { get; set; }

        public decimal MarketValue { get; set; }

        public int FootId { get; set; }

        public Foot Foot { get; set; }

        public int Appearances { get; set; }

        public int GoalCount { get; set; }

        public int AssistCount { get; set; }

        public Player()
        {
        }
        
        public Player(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
        }
    }
}
