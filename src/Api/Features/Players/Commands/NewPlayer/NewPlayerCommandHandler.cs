using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Players.Commands.NewPlayer
{
    public class NewPlayerCommandHandler : NewCommandHandlerBase<NewPlayerCommand, Player>
    {
        public NewPlayerCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }

        protected override Player CreateInstanceFromCommand(NewPlayerCommand request) =>
            new Player(
                request.FirstName,
                request.LastName,
                request.CountryId,
                request.BirthDate,
                request.Height,
                request.Weight,
                request.MarketValue,
                request.PositionId,
                request.SquadNumber,
                request.PictureUrl,
                request.Foot,
                request.ClubId,
                request.Salary);
    }
}
