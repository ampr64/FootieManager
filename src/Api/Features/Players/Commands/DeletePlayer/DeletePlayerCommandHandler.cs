using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Clubs.Commands.DeletePlayer
{
    public class DeletePlayerCommandHandler : DeleteCommandHandlerBase<DeletePlayerCommand, Player>
    {
        public DeletePlayerCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
