using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Stadiums.Commands.DeleteStadium
{
    public class DeleteStadiumCommandHandler : DeleteEntityCommandHandler<DeleteStadiumCommand, Stadium>
    {
        public DeleteStadiumCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
