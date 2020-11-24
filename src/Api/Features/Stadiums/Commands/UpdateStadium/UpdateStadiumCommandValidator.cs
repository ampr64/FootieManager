using FluentValidation;

namespace Api.Features.Stadiums.Commands.UpdateStadium
{
    public class UpdateStadiumCommandValidator : AbstractValidator<UpdateStadiumCommand>
    {
        public UpdateStadiumCommandValidator()
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
