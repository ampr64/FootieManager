using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommandHandler : UpdateCommandHandlerBase<UpdateCountryCommand, Country>
    {
        public UpdateCountryCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
