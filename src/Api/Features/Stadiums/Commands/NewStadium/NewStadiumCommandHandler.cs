using Api.Common.Commands;
using AutoMapper;
using Core.Common;
using Core.Entities;

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
