﻿using Api.Common.Commands;
using Api.Common.Mappings;
using ApplicationCore.Entities;

namespace Api.Features.Clubs.Commands.NewClub
{
    public class NewClubCommand : ICommand<int>, ICommandMap<Club>
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public string President { get; set; }

        public int? CoachId { get; set; }

        public int StadiumId { get; set; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }

        public string BadgeImageUrl { get; set; }
    }
}
