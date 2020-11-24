using FluentValidation;

namespace Api.Features.Leagues.Commands.NewLeague
{
    public class NewLeagueCommandValidator : AbstractValidator<NewLeagueCommand>
    {
        public NewLeagueCommandValidator()
        {
            RuleFor(l => l.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
