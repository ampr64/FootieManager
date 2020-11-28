using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommandHandler : DeleteCommandHandlerBase <DeleteClubCommand, Club>
    {
        public DeleteClubCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
