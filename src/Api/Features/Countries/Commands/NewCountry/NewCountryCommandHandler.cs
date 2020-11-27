using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommandHandler : NewEntityCommandHandler<NewCountryCommand, Country>
    {
        public NewCountryCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }

        protected override Country CreateInstanceFromCommand(NewCountryCommand request) =>
            new Country(
                request.Name,
                request.ContinentId,
                request.FlagImageUrl);
    }
}
