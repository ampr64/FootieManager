using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachCommandHandler : IRequestHandler<UpdateCoachCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCoachCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(UpdateCoachCommand request, CancellationToken cancellationToken)
        {
            var coach = await _context.Coaches.FindAsync(request.Id, cancellationToken);

            if (coach is null)
                throw new NotFoundException(nameof(Coach), request.Id);

            coach.FirstName = request.FirstName;
            coach.LastName = request.LastName;
            coach.PictureUrl = request.PictureUrl;
            coach.ClubId = request.ClubId;
            coach.Salary = request.Salary;

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
