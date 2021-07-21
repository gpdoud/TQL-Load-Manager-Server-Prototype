using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoadManagerPrototype.Data;
using LoadManagerPrototype.Models;

namespace LoadManagerPrototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispatchersController : ControllerBase
    {
        private readonly LoadManagerPrototypeContext _context;

        public DispatchersController(LoadManagerPrototypeContext context)
        {
            _context = context;
        }

        // GET: api/Dispatchers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dispatcher>>> GetDispatcher()
        {
            return await _context.Dispatcher.ToListAsync();
        }

        // GET: api/Dispatchers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dispatcher>> GetDispatcher(int id)
        {
            var dispatcher = await _context.Dispatcher.FindAsync(id);

            if (dispatcher == null)
            {
                return NotFound();
            }

            return dispatcher;
        }

        // PUT: api/Dispatchers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDispatcher(int id, Dispatcher dispatcher)
        {
            if (id != dispatcher.Id)
            {
                return BadRequest();
            }

            _context.Entry(dispatcher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DispatcherExists(id))
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

        // POST: api/Dispatchers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Dispatcher>> PostDispatcher(Dispatcher dispatcher)
        {
            _context.Dispatcher.Add(dispatcher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDispatcher", new { id = dispatcher.Id }, dispatcher);
        }

        // DELETE: api/Dispatchers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dispatcher>> DeleteDispatcher(int id)
        {
            var dispatcher = await _context.Dispatcher.FindAsync(id);
            if (dispatcher == null)
            {
                return NotFound();
            }

            _context.Dispatcher.Remove(dispatcher);
            await _context.SaveChangesAsync();

            return dispatcher;
        }

        private bool DispatcherExists(int id)
        {
            return _context.Dispatcher.Any(e => e.Id == id);
        }
    }
}
