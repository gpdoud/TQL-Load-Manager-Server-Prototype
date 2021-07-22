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
    public class CommodityPickupsController : ControllerBase
    {
        private readonly LoadManagerPrototypeContext _context;

        public CommodityPickupsController(LoadManagerPrototypeContext context)
        {
            _context = context;
        }

        // GET: api/CommodityPickups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommodityPickup>>> GetCommodityPickup()
        {
            return await _context.CommodityPickup.ToListAsync();
        }

        // GET: api/CommodityPickups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommodityPickup>> GetCommodityPickup(int id)
        {
            var commodityPickup = await _context.CommodityPickup.FindAsync(id);

            if (commodityPickup == null)
            {
                return NotFound();
            }

            return commodityPickup;
        }

        // PUT: api/CommodityPickups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommodityPickup(int id, CommodityPickup commodityPickup)
        {
            if (id != commodityPickup.Id)
            {
                return BadRequest();
            }

            _context.Entry(commodityPickup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommodityPickupExists(id))
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

        // POST: api/CommodityPickups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CommodityPickup>> PostCommodityPickup(CommodityPickup commodityPickup)
        {
            _context.CommodityPickup.Add(commodityPickup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommodityPickup", new { id = commodityPickup.Id }, commodityPickup);
        }

        // DELETE: api/CommodityPickups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CommodityPickup>> DeleteCommodityPickup(int id)
        {
            var commodityPickup = await _context.CommodityPickup.FindAsync(id);
            if (commodityPickup == null)
            {
                return NotFound();
            }

            _context.CommodityPickup.Remove(commodityPickup);
            await _context.SaveChangesAsync();

            return commodityPickup;
        }

        private bool CommodityPickupExists(int id)
        {
            return _context.CommodityPickup.Any(e => e.Id == id);
        }
    }
}
