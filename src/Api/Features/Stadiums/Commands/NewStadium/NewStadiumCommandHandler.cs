using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Stadiums.Commands.NewStadium
{
    public class NewStadiumCommandHandler : IRequestHandler<NewStadiumCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public NewStadiumCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<int> Handle(NewStadiumCommand request, CancellationToken cancellationToken)
        {
            var stadium = new Stadium(
                request.Name,
                request.Capacity,
                request.YearBuilt);

            await _context.Stadiums.AddAsync(stadium, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return stadium.Id;
        }
    }
}
