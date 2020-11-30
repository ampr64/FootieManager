using Core.Common;
using Core.Enums;
using System;

namespace Core.Entities
{
    public class Player : Person
    {
        public int? ClubId { get; set; }

        public Club Club { get; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public Foot Foot { get; set; }

        public Position Position { get; set; }

        public decimal? Salary { get; set; }

        public decimal MarketValue { get; set; }

        public int? SquadNumber { get; set; }


        public Player()
        {
        }
        
        public Player(string firstName, string lastName, DateTime birthDate, int height, int weight,
            decimal marketValue, Foot foot, Position position, int ? countryId = null, int? squadNumber = null, string pictureUrl = null, int? clubId = null,
            decimal? salary = null)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
            ClubId = clubId;
            Height = height;
            Weight = weight;
            Foot = foot;
            Position = position;
            MarketValue = marketValue;
            Salary = salary;
            SquadNumber = squadNumber;
        }
    }
}
