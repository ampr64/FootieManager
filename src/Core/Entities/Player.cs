using Domain.Common;
using Domain.Enumerations;
using System;

namespace Domain.Entities
{
    public class Player : Person
    {
        public int ClubId { get; set; }

        public Club Club { get; set; }

        public decimal Salary { get; set; }

        public int GoalCount { get; set; }

        public int AssistCount { get; set; }

        public Position Position { get; set; }

        public Player(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl, int clubId, int positionId)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
            ClubId = clubId;
        }
    }
}
