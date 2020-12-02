using Core.Services;
using FluentValidation;
using System;

namespace Api.Features.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachCommandValidator : AbstractValidator<UpdateCoachCommand>
    {
        private readonly IAgeCalculator _ageCalculator;

        public UpdateCoachCommandValidator(IAgeCalculator ageCalculator)
        {
            _ageCalculator = ageCalculator;

            RuleFor(c => c.FirstName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(c => c.LastName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(c => c.BirthDate)
                .Must(BeBetween20And99YearsOld)
                .WithMessage("A coach must be between 20 and 99 years old.");

            RuleFor(c => c.Salary)
                .GreaterThan(0);
        }

        private bool BeBetween20And99YearsOld(DateTime birthDate)
        {
            var age = _ageCalculator.CalculateAge(birthDate);

            return age >= 20 && age < 100;
        }
    }
}
