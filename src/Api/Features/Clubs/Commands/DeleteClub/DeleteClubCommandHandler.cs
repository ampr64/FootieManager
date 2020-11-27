using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommandHandler : DeleteEntityCommandHandler<DeleteClubCommand, Club>
    {
        public DeleteClubCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
