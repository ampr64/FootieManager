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

            player.FirstName = request.FirstName;
            player.LastName = request.LastName;
            player.PictureUrl = request.PictureUrl;
            player.ClubId = request.ClubId;
            player.Salary = request.Salary;

            return Unit.Value;
        }
    }
}
