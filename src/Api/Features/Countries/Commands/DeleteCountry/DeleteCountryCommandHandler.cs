using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommandHandler : DeleteCommandHandlerBase<DeleteCountryCommand, Country>
    {
        public DeleteCountryCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
