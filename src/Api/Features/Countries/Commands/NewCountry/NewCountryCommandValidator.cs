﻿using FluentValidation;

namespace Api.Features.Countries.Commands.NewCountry
{
    public class NewCountryCommandValidator : AbstractValidator<NewCountryCommand>
    {
        public NewCountryCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(c => c.IsoCode.Trim())
                .Length(2);
        }
    }
}
