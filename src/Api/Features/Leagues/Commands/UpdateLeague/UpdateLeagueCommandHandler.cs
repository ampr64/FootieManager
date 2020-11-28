﻿using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Leagues.Commands.UpdateLeague
{
    public class UpdateLeagueCommandHandler : UpdateCommandHandlerBase<UpdateLeagueCommand, League>
    {
        public UpdateLeagueCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
