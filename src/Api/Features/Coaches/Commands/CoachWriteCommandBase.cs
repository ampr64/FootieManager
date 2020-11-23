using MediatR;
using System;

namespace Api.Features.Coaches.Commands
{
    public abstract class CoachWriteCommandBase : IBaseRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CountryId { get; set; }

        public DateTime BirthDate { get; set; }

        public string PictureUrl { get; set; }

        public int? ClubId { get; set; }

        public decimal? Salary { get; set; }
    }

    public abstract class CoachWriteCommandBase<TResponse> : CoachWriteCommandBase, IRequest<TResponse>
    {
    }
}
