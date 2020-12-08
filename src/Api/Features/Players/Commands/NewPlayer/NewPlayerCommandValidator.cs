using ApplicationCore.Interfaces;
using FluentValidation;
using System;

namespace Api.Features.Players.Commands.NewPlayer
{
    public class NewPlayerCommandValidator : AbstractValidator<NewPlayerCommand>
    {
        private readonly IAgeCalculator _ageCalculator;

        public NewPlayerCommandValidator(IAgeCalculator ageCalculator)
        {
            _ageCalculator = ageCalculator;

            RuleFor(p => p.FirstName)
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
                .GreaterThan(0)
                .When(HasClub);

            RuleFor(p => p.SquadNumber)
                .InclusiveBetween(1, 99)
                .When(HasClub);

            RuleFor(c => c.BirthDate)
                .Must(BeBetween15And50YearsOld)
                .WithMessage("A player must be between 15 and 50 years old.");
        }

        private bool BeBetween15And50YearsOld(DateTime birthDate)
        {
            var age = _ageCalculator.CalculateAge(birthDate);

            return age >= 20 && age <= 50;
        }

        private bool HasClub(NewPlayerCommand player) => player.ClubId != null;
    }
}
