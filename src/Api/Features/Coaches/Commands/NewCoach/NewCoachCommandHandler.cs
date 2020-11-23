using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Coaches.Commands.NewCoach
{
    public class NewCoachCommandHandler : IRequestHandler<NewCoachCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public NewCoachCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<int> Handle(NewCoachCommand request, CancellationToken cancellationToken)
        {
            var coach = new Coach(
                request.FirstName,
                request.LastName,
                request.CountryId,
                request.BirthDate,
                request.PictureUrl,
                request.ClubId,
                request.Salary);

            await _context.Coaches.AddAsync(coach, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return coach.Id;
        }
    }
}
