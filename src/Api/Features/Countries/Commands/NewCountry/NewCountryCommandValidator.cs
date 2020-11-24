using FluentValidation;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommandValidator : AbstractValidator<NewCountryCommand>
    {
        public NewCountryCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
