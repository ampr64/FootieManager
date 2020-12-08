using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Stadiums.Commands.DeleteStadium
{
    public class DeleteStadiumCommandHandler : DeleteCommandHandlerBase<DeleteStadiumCommand, Stadium>
    {
        public DeleteStadiumCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
