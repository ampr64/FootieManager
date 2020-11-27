﻿using Api.Common.Commands;
using Core.Common;
using Core.Entities;

namespace Api.Features.Stadiums.Commands.UpdateStadium
{
    public class UpdateStadiumCommandHandler : UpdateEntityCommandHandler<UpdateStadiumCommand, Player>
    {
        public UpdateStadiumCommandHandler(IApplicationDbContext context)
            : base(context)
        {
        }
    }
}
