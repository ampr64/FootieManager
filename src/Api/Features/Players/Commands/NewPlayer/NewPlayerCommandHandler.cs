using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Players.Commands.NewPlayer
{
    public class NewPlayerCommandHandler : IRequestHandler<NewPlayerCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public NewPlayerCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<int> Handle(NewPlayerCommand request, CancellationToken cancellationToken)
        {
            var player = new Player(
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

            await _context.Players.AddAsync(player, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return player.Id;
        }
    }
}
