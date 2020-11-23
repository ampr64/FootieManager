using FluentValidation;

namespace Api.Features.Players.Commands.NewPlayer
{
    public class NewPlayerCommandValidator : AbstractValidator<NewPlayerCommand>
    {
        public NewPlayerCommandValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(c => c.LastName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(p => p.Height)
            .InclusiveBetween(140, 250);

            RuleFor(p => p.Weight)
                .InclusiveBetween(45, 180);

            RuleFor(p => p.Position)
                .IsInEnum();

            RuleFor(p => p.Foot)
                .IsInEnum();

            RuleFor(p => p.MarketValue)
                .GreaterThan(0);

            RuleFor(p => p.Salary)
                .GreaterThan(0);
        }
    }
}
