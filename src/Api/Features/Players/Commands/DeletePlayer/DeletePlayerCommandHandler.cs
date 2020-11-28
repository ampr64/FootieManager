using Api.Common.Commands;
using Core.Common;
using Core.Entities;

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
