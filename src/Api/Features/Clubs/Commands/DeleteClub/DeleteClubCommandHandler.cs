using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
