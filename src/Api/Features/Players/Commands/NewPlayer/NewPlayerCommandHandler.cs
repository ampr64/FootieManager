using Api.Common.Commands;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Players.Commands.NewPlayer
{
    public class NewPlayerCommandHandler : NewCommandHandlerBase<NewPlayerCommand, Player>
    {
        public NewPlayerCommandHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }            
    }
}
