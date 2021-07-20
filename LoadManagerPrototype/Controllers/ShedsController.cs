using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoadManagerPrototype.Data;

namespace LoadManagerPrototype.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShedsController : ControllerBase
    {
        private readonly LoadManagerPrototypeContext _context;

        public ShedsController(LoadManagerPrototypeContext context)
        {
            _context = context;
        }

        // GET: api/Sheds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shed>>> GetShed()
        {
            return await _context.Shed.ToListAsync();
        }

        // GET: api/Sheds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Shed>> GetShed(int id)
        {
            var shed = await _context.Shed.FindAsync(id);

            if (shed == null)
            {
                return NotFound();
            }

            return shed;
        }

        // PUT: api/Sheds/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShed(int id, Shed shed)
        {
            if (id != shed.Id)
            {
                return BadRequest();
            }

            _context.Entry(shed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShedExists(id))
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

        // POST: api/Sheds
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Shed>> PostShed(Shed shed)
        {
            _context.Shed.Add(shed);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShed", new { id = shed.Id }, shed);
        }

        // DELETE: api/Sheds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Shed>> DeleteShed(int id)
        {
            var shed = await _context.Shed.FindAsync(id);
            if (shed == null)
            {
                return NotFound();
            }

            _context.Shed.Remove(shed);
            await _context.SaveChangesAsync();

            return shed;
        }

        private bool ShedExists(int id)
        {
            return _context.Shed.Any(e => e.Id == id);
        }
    }
}
