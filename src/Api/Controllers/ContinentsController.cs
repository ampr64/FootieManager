using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContinentsController : ControllerBase
    {
        private readonly IContinentService _service;

        public ContinentsController(IContinentService continentService)
        {
            _service = continentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Continent>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Continent> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] Continent continent)
        {
            await _service.NewAsync(continent);
            return CreatedAtAction(nameof(Get), new { id = continent.Id }, continent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Continent continent)
        {
            if (id != continent.Id)
                return BadRequest();

            await _service.UpdateAsync(continent);
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
