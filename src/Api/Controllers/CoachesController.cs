﻿using Api.Features.Clubs.Commands.DeleteCoach;
using Api.Features.Coaches.Commands.NewCoach;
using Api.Features.Coaches.Commands.UpdateCoach;
using Api.Features.Coaches.Queries;
using Api.Features.Coaches.Queries.GetAvailableCoaches;
using Api.Features.Coaches.Queries.GetCoachDetail;
using Api.Features.Coaches.Queries.GetCoaches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Authorize]
    public class CoachesController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CoachDto>>> List()
        {
            var coaches = await Mediator.Send(new GetCoachesQuery());

            return Ok(coaches);
        }

        [HttpGet("available")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CoachDto>>> ListAvailable()
        {
            var availableCoaches = await Mediator.Send(new GetAvailableCoachesQuery());

            return Ok(availableCoaches);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<CoachDto>> GetDetail(int id)
        {
            return await Mediator.Send(new GetCoachDetailQuery(id));
        }

        [HttpPost]
        public async Task<IActionResult> New(NewCoachCommand command)
        {
            var id = await Mediator.Send(command);

            return CreatedAtAction(nameof(GetDetail), id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCoachCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteCoachCommand(id));

            return NoContent();
        }
    }
}
