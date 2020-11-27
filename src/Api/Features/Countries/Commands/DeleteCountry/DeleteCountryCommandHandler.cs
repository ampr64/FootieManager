using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommandHandler : DeleteEntityCommandHandler<DeleteCountryCommand, Country>
    {
        public DeleteCountryCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
