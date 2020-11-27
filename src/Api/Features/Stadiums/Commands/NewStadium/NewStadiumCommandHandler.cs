using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Stadiums.Commands.NewStadium
{
    public class NewStadiumCommandHandler : NewEntityCommandHandler<NewStadiumCommand, Stadium>
    {
        public NewStadiumCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }

        protected override Stadium CreateInstanceFromCommand(NewStadiumCommand request) =>
            new Stadium(
                request.Name,
                request.Capacity,
                request.YearBuilt);
    }
}
