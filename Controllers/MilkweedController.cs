using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GotMilkWeed.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MilkweedVarietiesController : ControllerBase
    {
        private readonly MilkweedDbContext _context;

        public MilkweedVarietiesController(MilkweedDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MilkweedVariety>>> GetAllMilkweedVarieties()
        {
            return await _context.GetMilkweedVarieties().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MilkweedVariety>> GetMilkweedVariety(int id)
        {
            var milkweedVariety = await _context.GetMilkweedVarieties().FindAsync(id);

            if (milkweedVariety == null)
            {
                return NotFound();
            }

            return milkweedVariety;
        }

        [HttpPost]
        public async Task<ActionResult<MilkweedVariety>> AddMilkweedVariety(MilkweedVariety milkweedVariety)
        {
            _context.GetMilkweedVarieties().Add(milkweedVariety);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMilkweedVariety), new { id = milkweedVariety.Id }, milkweedVariety);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMilkweedVariety(int id, MilkweedVariety milkweedVariety)
        {
            if (id != milkweedVariety.Id)
            {
                return BadRequest();
            }

            _context.Entry(milkweedVariety).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MilkweedVarietyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMilkweedVariety(int id)
        {
            var milkweedVariety = await _context.GetMilkweedVarieties().FindAsync(id);

            if (milkweedVariety == null)
            {
                return NotFound();
            }

            _context.GetMilkweedVarieties().Remove(milkweedVariety);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MilkweedVarietyExists(int id)
        {
            return _context.GetMilkweedVarieties().Any(e => e.Id == id);
        }
    }
}