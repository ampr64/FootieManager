using Api.Exceptions;
using Core.Common;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCountryCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<Unit> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
        {
            var country = await _context.Countries.FindAsync(request.Id, cancellationToken);

            if (country is null)
                throw new NotFoundException(nameof(Country), request.Id);

            country.Name = request.Name;
            country.ContinentId = request.ContinentId;
            country.FlagImageUrl = request.FlagImageUrl;

            await _context.CommitChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
