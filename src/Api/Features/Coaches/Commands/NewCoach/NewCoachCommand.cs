using Api.Common.Commands;
using Api.Common.Mappings;
using Core.Entities;
using System;

namespace Api.Features.Coaches.Commands.NewCoach
{
    public class NewCoachCommand : ICommand<int>, ICommandMap<Coach>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? CountryId { get; set; }

        public DateTime BirthDate { get; set; }

        public string PictureUrl { get; set; }

        public int? ClubId { get; set; }

        public decimal? Salary { get; set; }
    }
}
