using Api.Common.Core;
using Api.Common.Mappings;
using Core.Entities;
using System;

namespace Api.Features.Coaches.Queries
{
    public class CoachDto : IDto<Coach>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? CountryId { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age => new AgeCalculator().CalculateAge(BirthDate);

        public string PictureUrl { get; set; }

        public int? ClubId { get; set; }

        public decimal? Salary { get; set; }
    }
}
