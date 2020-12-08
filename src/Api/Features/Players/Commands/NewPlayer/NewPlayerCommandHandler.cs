using Api.Common.Commands;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
