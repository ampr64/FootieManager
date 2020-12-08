using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Clubs.Commands.DeleteCoach
{
    public class DeleteCoachCommandHandler : DeleteCommandHandlerBase<DeleteCoachCommand, Coach>
    {
        public DeleteCoachCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
