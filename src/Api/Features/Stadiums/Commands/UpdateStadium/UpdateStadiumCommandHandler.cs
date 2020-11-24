using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Stadiums.Commands.UpdateStadium
{
    public class UpdateStadiumCommandHandler : IRequestHandler<UpdateStadiumCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateStadiumCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(UpdateStadiumCommand request, CancellationToken cancellationToken)
        {
            var stadium = await _context.Stadiums.FindAsync(request.Id, cancellationToken);

            if (stadium is null)
                throw new NotFoundException(nameof(Stadium), request.Id);

            stadium.Name = request.Name;
            stadium.Capacity = request.Capacity;
            stadium.YearBuilt = request.YearBuilt;

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
