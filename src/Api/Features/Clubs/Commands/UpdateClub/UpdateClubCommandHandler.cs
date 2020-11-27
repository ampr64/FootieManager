using Api.Common.Commands;
using Api.Exceptions;
using Api.Features.Clubs.Commands.UpdateClub;
using Core.Common;
using Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Commands.UpdateClubDetails
{
    public class UpdateClubCommandHandler : UpdateEntityCommandHandler<UpdateClubCommand, Club>
    {
        public UpdateClubCommandHandler(IApplicationDbContext context) : base(context)
        {
        }
    }
}
