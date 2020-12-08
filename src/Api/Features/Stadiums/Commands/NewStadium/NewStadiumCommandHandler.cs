using Api.Common.Commands;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Stadiums.Commands.NewStadium
{
    public class NewStadiumCommandHandler : NewCommandHandlerBase<NewStadiumCommand, Stadium>
    {
        public NewStadiumCommandHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
