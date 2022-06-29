using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HamsterWars.api.Data;
using HamsterWars.data;

namespace HamsterWars.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        private readonly HamsterDbContext _context;

        public HamstersController(HamsterDbContext context)
        {
            _context = context;
        }

        // GET: api/Hamsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetHamsters()
        {
            if (_context.Hamsters == null)
            {
                return NotFound();
            }
            return await _context.Hamsters.ToListAsync();
        }

        [HttpGet("random")]
        public async Task<ActionResult<IEnumerable<Hamster>>> randomizer()
        {
            var max = await _context.Hamsters.CountAsync();
            var min = await _context.Hamsters
                .OrderBy(x => x.Id)
                .FirstOrDefaultAsync();

            Hamster? hamster = null;

            var random = new Random().Next(min.Id, max);

            // ensure the hamster is not competing against itself 
            while (hamster == null)
                hamster = getHamster(random);

            return StatusCode(200, hamster);
        }

        Hamster? getHamster(int id)
        {
            return _context
                .Hamsters
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }


        // GET: api/Hamsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hamster>> GetHamster(int id)
        {
            if (_context.Hamsters == null)
            {
                return NotFound();
            }
            var hamster = await _context.Hamsters
                .FindAsync(id);

            if (hamster == null)
            {
                return NotFound();
            }

            return hamster;
        }

        // PUT: api/Hamsters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHamster(int id, Hamster hamster)
        {
            if (id != hamster.Id)
            {
                return BadRequest();
            }

            _context.Entry(hamster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HamsterExists(id))
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

        // POST: api/Hamsters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hamster>> PostHamster(Hamster hamster)
        {
            if (_context.Hamsters == null)
            {
                return Problem("Entity set is null.");
            }
            _context.Hamsters.Add(hamster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHamster", new { id = hamster.Id }, hamster);
        }

        // DELETE: api/Hamsters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHamster(int id)
        {
            if (_context.Hamsters == null)
            {
                return NotFound();
            }
            var hamster = await _context.Hamsters
                .FindAsync(id);
            if (hamster == null)
            {
                return NotFound();
            }

            _context.Hamsters.Remove(hamster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HamsterExists(int id)
        {
            return (_context.Hamsters?
                .Any(e => e.Id == id))
                .GetValueOrDefault();
        }
    }
}
