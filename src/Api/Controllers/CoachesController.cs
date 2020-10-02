using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachsController : ControllerBase
    {
        private readonly ICoachService _service;

        public CoachsController(ICoachService coachService)
        {
            _service = coachService;
        }

        [HttpGet]
        public async Task<IEnumerable<Coach>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Coach> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] Coach coach)
        {
            await _service.NewAsync(coach);
            return CreatedAtAction(nameof(Get), new { id = coach.Id }, coach);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Coach coach)
        {
            if (id != coach.Id)
                return BadRequest();

            await _service.UpdateAsync(coach);
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
