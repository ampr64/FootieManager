using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Coaches.Commands.NewCoach
{
    public class NewCoachCommandHandler : NewEntityCommandHandler<NewCoachCommand, Coach>
    {

        public NewCoachCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }

        protected override Coach CreateInstanceFromCommand(NewCoachCommand request) =>
            new Coach(
                request.FirstName,
                request.LastName,
                request.CountryId,
                request.BirthDate,
                request.PictureUrl,
                request.ClubId,
                request.Salary);
    }
}
