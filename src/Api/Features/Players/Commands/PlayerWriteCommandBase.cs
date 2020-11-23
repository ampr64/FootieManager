using Core.Enums;
using MediatR;
using System;

namespace Api.Features.Players.Commands
{
    public abstract class PlayerWriteCommandBase<TResponse> : IRequest<TResponse>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CountryId { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public Foot Foot { get; set; }

        public Position Position { get; set; }

        public string PictureUrl { get; set; }

        public int? ClubId { get; set; }

        public decimal MarketValue { get; set; }

        public decimal? Salary { get; set; }
    }
}
