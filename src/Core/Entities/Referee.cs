using Core.Common;
using System;

namespace Core.Entities
{
    public class Referee : Person
    {
        public int? LeagueId { get; set; }

        public League League { get; set; }

        public Referee(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl, int? leagueId)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
            LeagueId = leagueId;
        }
    }
}
