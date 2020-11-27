using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Clubs.Commands.DeleteCoach
{
    public class DeleteCoachCommandHandler : DeleteEntityCommandHandler<DeleteCoachCommand, Coach>
    {
        public DeleteCoachCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
