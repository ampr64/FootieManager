using Api.Features.Leagues.Commands.DeleteLeague;
using Api.Features.Leagues.Commands.NewLeague;
using Api.Features.Leagues.Commands.UpdateLeague;
using Api.Features.Leagues.Queries;
using Api.Features.Leagues.Queries.GetCountryLeagues;
using Api.Features.Leagues.Queries.GetLeagueDetail;
using Api.Features.Leagues.Queries.GetLeagues;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Authorize]
    public class LeaguesController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<LeagueDto>>> List()
        {
            var leagues = await Mediator.Send(new GetLeaguesQuery());

            return Ok(leagues);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<LeagueDto>> GetDetail(int id)
        {
            return await Mediator.Send(new GetLeagueDetailQuery(id));
        }

        [HttpGet("countries/{countryId}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<LeagueDto>>> GetCountryLeagues(int countryId)
        {
            var leagues = await Mediator.Send(new GetCountryLeaguesQuery(countryId));

            return Ok(leagues);
        }

        [HttpPost]
        public async Task<IActionResult> New(NewLeagueCommand command)
        {
            var id = await Mediator.Send(command);

            return new CreatedResult(nameof(GetDetail), id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateLeagueCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteLeagueCommand(id));

            return NoContent();
        }
    }
}
