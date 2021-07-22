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
    public class CommodityDeliveriesController : ControllerBase
    {
        private readonly LoadManagerPrototypeContext _context;

        public CommodityDeliveriesController(LoadManagerPrototypeContext context)
        {
            _context = context;
        }

        // GET: api/CommodityDeliveries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommodityDelivery>>> GetCommodityDelivery()
        {
            return await _context.CommodityDelivery.ToListAsync();
        }

        // GET: api/CommodityDeliveries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommodityDelivery>> GetCommodityDelivery(int id)
        {
            var commodityDelivery = await _context.CommodityDelivery.FindAsync(id);

            if (commodityDelivery == null)
            {
                return NotFound();
            }

            return commodityDelivery;
        }

        // PUT: api/CommodityDeliveries/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommodityDelivery(int id, CommodityDelivery commodityDelivery)
        {
            if (id != commodityDelivery.Id)
            {
                return BadRequest();
            }

            _context.Entry(commodityDelivery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommodityDeliveryExists(id))
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

        // POST: api/CommodityDeliveries
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CommodityDelivery>> PostCommodityDelivery(CommodityDelivery commodityDelivery)
        {
            _context.CommodityDelivery.Add(commodityDelivery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommodityDelivery", new { id = commodityDelivery.Id }, commodityDelivery);
        }

        // DELETE: api/CommodityDeliveries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CommodityDelivery>> DeleteCommodityDelivery(int id)
        {
            var commodityDelivery = await _context.CommodityDelivery.FindAsync(id);
            if (commodityDelivery == null)
            {
                return NotFound();
            }

            _context.CommodityDelivery.Remove(commodityDelivery);
            await _context.SaveChangesAsync();

            return commodityDelivery;
        }

        private bool CommodityDeliveryExists(int id)
        {
            return _context.CommodityDelivery.Any(e => e.Id == id);
        }
    }
}
