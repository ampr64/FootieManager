using FluentValidation;

namespace Api.Features.Clubs.Commands.NewClub
{
    public class NewClubCommandValidator : AbstractValidator<NewClubCommand>
    {
        public NewClubCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(c => c.Owner)
                .MaximumLength(50);

            RuleFor(c => c.TrophyCount)
                .GreaterThanOrEqualTo(0);

            RuleFor(c => c.YearFounded)
                .GreaterThan(1800);
        }
    }
}
