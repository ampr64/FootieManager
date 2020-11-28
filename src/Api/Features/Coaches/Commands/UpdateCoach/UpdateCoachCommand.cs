using Api.Common.Commands;
using System;

namespace Api.Features.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachCommand : UpdateCommand
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CountryId { get; set; }

        public DateTime BirthDate { get; set; }

        public string PictureUrl { get; set; }

        public int? ClubId { get; set; }

        public decimal? Salary { get; set; }
    }
}
