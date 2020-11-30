using Api.Common.Mappings;
using Core.Entities;
using Core.Enums;
using System;

namespace Api.Features.Players.Queries
{
    public class PlayerDto : IDto<Player>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CountryId { get; set; }

        public DateTime BirthDate { get; set; }

        public string PictureUrl { get; set; }

        public int? ClubId { get; set; }

        public Position Position { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public decimal? Salary { get; set; }

        public decimal MarketValue { get; set; }

        public int SquadNumber { get; set; }

        public Foot Foot { get; set; }
    }
}
