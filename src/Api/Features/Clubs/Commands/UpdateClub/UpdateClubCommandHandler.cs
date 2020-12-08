using Api.Common.Commands;
using Api.Features.Clubs.Commands.UpdateClub;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
