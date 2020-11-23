using Core.Common;
using FluentValidation;
using System;

namespace Api.Features.Coaches.Commands.NewCoach
{
    public abstract class CoachWriteCommandValidatorBase : AbstractValidator<CoachWriteCommandBase>
    {
        private readonly IAgeCalculator _ageCalculator;

        public CoachWriteCommandValidatorBase(IAgeCalculator ageCalculator)
        {
            _ageCalculator = ageCalculator;

            RuleFor(c => c.FirstName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(c => c.LastName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(c => c.BirthDate)
                .Must(BeAtLeast20YearsOld);

            RuleFor(c => c.Salary)
                .GreaterThan(0);
        }

        private bool BeAtLeast20YearsOld(DateTime birthDate) =>
            _ageCalculator.CalculateAge(birthDate) >= 20;
    }
}
