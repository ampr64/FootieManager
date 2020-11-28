using Api.Common.Commands;
using Api.Features.Clubs.Commands.UpdateClub;
using Core.Common;
using Core.Entities;

namespace Api.Features.Clubs.Commands.UpdateClubDetails
{
    public class UpdateClubCommandHandler : UpdateCommandHandlerBase<UpdateClubCommand, Club>
    {
        public UpdateClubCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
