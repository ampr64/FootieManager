using FluentValidation;

namespace Api.Features.Leagues.Commands.UpdateLeague
{
    public class UpdateLeagueCommandValidator : AbstractValidator<UpdateLeagueCommand>
    {
        public UpdateLeagueCommandValidator()
        {
            RuleFor(l => l.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
