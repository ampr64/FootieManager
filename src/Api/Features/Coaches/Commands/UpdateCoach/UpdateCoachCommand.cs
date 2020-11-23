using MediatR;

namespace Api.Features.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachCommand : CoachWriteCommandBase<Unit>
    {
        public int Id { get; set; }
    }
}
