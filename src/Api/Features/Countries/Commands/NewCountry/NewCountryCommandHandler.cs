using Api.Common.Commands;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
