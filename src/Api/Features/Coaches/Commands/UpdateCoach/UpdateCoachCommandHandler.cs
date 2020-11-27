using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachCommandHandler : UpdateEntityCommandHandler<UpdateCoachCommand, Coach>
    {
        public UpdateCoachCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
