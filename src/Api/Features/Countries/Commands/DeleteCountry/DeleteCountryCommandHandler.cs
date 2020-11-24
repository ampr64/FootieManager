using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCountryCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            var country = await _context.Countries.FindAsync(request.Id, cancellationToken);

            if (country is null)
                throw new NotFoundException(nameof(Country), request.Id);

            _context.Countries.Remove(country);

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
