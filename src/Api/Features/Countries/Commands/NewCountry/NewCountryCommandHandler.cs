using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommandHandler : IRequestHandler<NewCountryCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public NewCountryCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<int> Handle(NewCountryCommand request, CancellationToken cancellationToken)
        {
            var country = new Country(request.Name, request.ContinentId, request.FlagImageUrl);

            await _context.Countries.AddAsync(country, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return country.Id;
        }
    }
}
