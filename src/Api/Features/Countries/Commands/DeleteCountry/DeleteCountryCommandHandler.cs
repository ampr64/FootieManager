using Api.Common.Commands;
using Core.Common;
using Core.Entities;

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
