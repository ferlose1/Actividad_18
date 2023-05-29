using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Actividad_18.Server.Context;
using Actividad_18.Shared.Models;

namespace Actividad_18.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasesController : ControllerBase
    {
        private readonly GymnacioContext _context;

        public ClasesController(GymnacioContext context)
        {
            _context = context;
        }

        // GET: api/Clases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clases>>> GetClases()
        {
            var clases = await _context.Clases.ToListAsync();
            return clases;
        }

        // GET: api/Clases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clases>> GetClases(int id)
        {
            var clases = await _context.Clases.FindAsync(id);

            if (clases == null)
            {
                return NotFound();
            }

            return clases;
        }

        // PUT: api/Clases/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClases(int id, Clases clases)
        {
            if (id != clases.Id)
            {
                return BadRequest();
            }

            _context.Entry(clases).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClasesExists(id))
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

        // POST: api/Clases
        [HttpPost]
        public async Task<ActionResult<Clases>> PostClases(Clases clases)
        {
            var cliente = await _context.Clientes.FindAsync(clases.ClientesId);
            if (cliente == null)
            {
                return NotFound("Cliente not found.");
            }

            _context.Clases.Add(clases);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClases", new { id = clases.Id }, clases);
        }

        // DELETE: api/Clases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClases(int id)
        {
            var clases = await _context.Clases.FindAsync(id);
            if (clases == null)
            {
                return NotFound();
            }

            _context.Clases.Remove(clases);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClasesExists(int id)
        {
            return _context.Clases.Any(e => e.Id == id);
        }
    }
}
