﻿using Api.Common.Commands;

namespace Api.Features.Clubs.Commands.UpdateClub
{
    public class UpdateClubCommand : UpdateCommand
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
