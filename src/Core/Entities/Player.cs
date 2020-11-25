﻿using Core.Common;
using Core.Enumerations;
using Core.Enums;
using System;

namespace Core.Entities
{
    public class Player : Person
    {
        public int? ClubId { get; set; }

        public Club Club { get; set; }

        public int PositionId { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public decimal? Salary { get; set; }

        public decimal MarketValue { get; set; }

        public Foot Foot { get; set; }

        public Player()
        {
        }
        
        public Player(string firstName, string lastName, int countryId, DateTime birthDate, int height, int weight,
            decimal marketValue, int positionId, string pictureUrl = null, Foot foot = Foot.Right, int? clubId = null,
            decimal? salary = null)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
            ClubId = clubId;
            Height = height;
            Weight = weight;
            Foot = foot;
            PositionId = positionId;
            MarketValue = marketValue;
            Salary = salary;
        }
    }
}
