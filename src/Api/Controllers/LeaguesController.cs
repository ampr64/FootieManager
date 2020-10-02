using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController : ControllerBase
    {
        private readonly ILeagueService _service;

        public LeaguesController(ILeagueService leagueService)
        {
            _service = leagueService;
        }

        [HttpGet]
        public async Task<IEnumerable<League>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<League> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] League league)
        {
            await _service.NewAsync(league);
            return CreatedAtAction(nameof(Get), new { id = league.Id }, league);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] League league)
        {
            if (id != league.Id)
                return BadRequest();

            await _service.UpdateAsync(league);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
