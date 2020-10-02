using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefereesController : ControllerBase
    {
        private readonly IRefereeService _service;

        public RefereesController(IRefereeService refereeService)
        {
            _service = refereeService;
        }

        [HttpGet]
        public async Task<IEnumerable<Referee>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Referee> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] Referee referee)
        {
            await _service.NewAsync(referee);
            return CreatedAtAction(nameof(Get), new { id = referee.Id }, referee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Referee referee)
        {
            if (id != referee.Id)
                return BadRequest();

            await _service.UpdateAsync(referee);
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
