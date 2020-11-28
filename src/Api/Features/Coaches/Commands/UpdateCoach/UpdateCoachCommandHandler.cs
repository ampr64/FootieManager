using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachCommandHandler : UpdateCommandHandlerBase<UpdateCoachCommand, Coach>
    {
        public UpdateCoachCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
