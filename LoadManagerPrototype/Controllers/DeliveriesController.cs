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
    public class DeliveriesController : ControllerBase
    {
        private readonly LoadManagerPrototypeContext _context;

        public DeliveriesController(LoadManagerPrototypeContext context)
        {
            _context = context;
        }

        // GET: api/Deliveries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Delivery>>> GetDelivery()
        {
            return await _context.Delivery.ToListAsync();
        }

        // GET: api/Deliveries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Delivery>> GetDelivery(int id)
        {
            var delivery = await _context.Delivery.FindAsync(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return delivery;
        }

        // PUT: api/Deliveries/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDelivery(int id, Delivery delivery)
        {
            if (id != delivery.Id)
            {
                return BadRequest();
            }

            _context.Entry(delivery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(id))
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

        // POST: api/Deliveries
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Delivery>> PostDelivery(Delivery delivery)
        {
            _context.Delivery.Add(delivery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDelivery", new { id = delivery.Id }, delivery);
        }

        // DELETE: api/Deliveries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Delivery>> DeleteDelivery(int id)
        {
            var delivery = await _context.Delivery.FindAsync(id);
            if (delivery == null)
            {
                return NotFound();
            }

            _context.Delivery.Remove(delivery);
            await _context.SaveChangesAsync();

            return delivery;
        }

        private bool DeliveryExists(int id)
        {
            return _context.Delivery.Any(e => e.Id == id);
        }
    }
}
