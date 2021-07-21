﻿using System;
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
    public class CommoditiesController : ControllerBase
    {
        private readonly LoadManagerPrototypeContext _context;

        public CommoditiesController(LoadManagerPrototypeContext context)
        {
            _context = context;
        }

        // GET: api/Commodities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commodity>>> GetCommodity()
        {
            return await _context.Commodity.ToListAsync();
        }

        // GET: api/Commodities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Commodity>> GetCommodity(int id)
        {
            var commodity = await _context.Commodity.FindAsync(id);

            if (commodity == null)
            {
                return NotFound();
            }

            return commodity;
        }

        // PUT: api/Commodities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommodity(int id, Commodity commodity)
        {
            if (id != commodity.Id)
            {
                return BadRequest();
            }

            _context.Entry(commodity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommodityExists(id))
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

        // POST: api/Commodities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Commodity>> PostCommodity(Commodity commodity)
        {
            _context.Commodity.Add(commodity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommodity", new { id = commodity.Id }, commodity);
        }

        // DELETE: api/Commodities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Commodity>> DeleteCommodity(int id)
        {
            var commodity = await _context.Commodity.FindAsync(id);
            if (commodity == null)
            {
                return NotFound();
            }

            _context.Commodity.Remove(commodity);
            await _context.SaveChangesAsync();

            return commodity;
        }

        private bool CommodityExists(int id)
        {
            return _context.Commodity.Any(e => e.Id == id);
        }
    }
}
