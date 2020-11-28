using Api.Common.Commands;
using Core.Common;
using Core.Entities;

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
