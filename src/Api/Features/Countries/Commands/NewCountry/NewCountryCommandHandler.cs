using Api.Common.Commands;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommandHandler : NewCommandHandlerBase<NewCountryCommand, Country>
    {
        public NewCountryCommandHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
