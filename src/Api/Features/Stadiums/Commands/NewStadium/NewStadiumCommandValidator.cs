using FluentValidation;

namespace Api.Features.Stadiums.Commands.NewStadium
{
    public class NewStadiumCommandValidator : AbstractValidator<NewStadiumCommand>
    {
        public NewStadiumCommandValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(s => s.Capacity)
                .GreaterThan(0);

            RuleFor(s => s.YearBuilt)
                .InclusiveBetween(1800, 3000);
        }
    }
}
