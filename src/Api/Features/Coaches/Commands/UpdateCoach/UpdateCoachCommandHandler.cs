using Api.Common.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
