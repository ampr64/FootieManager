using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Players.Commands.UpdatePlayer
{
    public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdatePlayerCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(UpdatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = await _context.Players.FindAsync(request.Id, cancellationToken);

            if (player is null)
                throw new NotFoundException(nameof(Coach), request.Id);

            UpdateValues(player, request);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }

        private void UpdateValues(Player player, UpdatePlayerCommand request)
        {
            player.FirstName = request.FirstName;
            player.LastName = request.LastName;
            player.CountryId = request.CountryId;
            player.BirthDate = request.BirthDate;
            player.Height = request.Height;
            player.Weight = request.Weight;
            player.MarketValue = request.MarketValue;
            player.PictureUrl = request.PictureUrl;
            player.Foot = request.Foot;
            player.Position = request.Position;
            player.ClubId = request.ClubId;
            player.Salary = request.Salary;
        }
    }
}
