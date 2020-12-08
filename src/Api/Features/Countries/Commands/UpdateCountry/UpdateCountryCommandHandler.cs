using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
