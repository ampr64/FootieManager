using FluentValidation;

namespace Api.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommandValidator : AbstractValidator<UpdateCountryCommand>
    {
        public UpdateCountryCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(c => c.IsoCode.Trim())
                .Length(2);
        }
    }
}
