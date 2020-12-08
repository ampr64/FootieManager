using Api.Common.Commands;
using Api.Common.Mappings;
using ApplicationCore.Entities;
using ApplicationCore.Enums;
using System;

namespace Api.Features.Players.Commands.NewPlayer
{
    public class NewPlayerCommand : ICommand<int>, ICommandMap<Player>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? CountryId { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public Foot Foot { get; set; }

        public Position Position { get; set; }

        public string PictureUrl { get; set; }

        public int? ClubId { get; set; }

        public decimal MarketValue { get; set; }

        public decimal? Salary { get; set; }

        public int? SquadNumber { get; set; }
    }
}
