using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        public ClubsController(IClubService clubService)
        {
            _service = clubService;
        }

        [HttpGet]
        public async Task<IEnumerable<Club>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Club> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] Club club)
        {
            await _service.NewAsync(club);
            return CreatedAtAction(nameof(Get), new { id = club.Id }, club);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Club club)
        {
            if (id != club.Id)
                return BadRequest();

            await _service.UpdateAsync(club);
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
