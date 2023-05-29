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
    public class MedidasController : ControllerBase
    {
        private readonly GymnacioContext _context;

        public MedidasController(GymnacioContext context)
        {
            _context = context;
        }

        // GET: api/Medidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medidas>>> GetMedidas()
        {
            var medidas = await _context.Medidas.ToListAsync();
            return medidas;
        }

        // GET: api/Medidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medidas>> GetMedidas(int id)
        {
            var medidas = await _context.Medidas.FindAsync(id);

            if (medidas == null)
            {
                return NotFound();
            }

            return medidas;
        }

        // PUT: api/Medidas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedidas(int id, Medidas medidas)
        {
            if (id != medidas.Id)
            {
                return BadRequest();
            }

            _context.Entry(medidas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedidasExists(id))
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

        // POST: api/Medidas
        [HttpPost]
        public async Task<ActionResult<Medidas>> PostMedidas(Medidas medidas)
        {
            var cliente = await _context.Clientes.FindAsync(medidas.CLientesId);
            if (cliente == null)
            {
                return NotFound("Cliente not found.");
            }

            // Asignar el valor del campo "nombre" del cliente al campo "nombre" de las medidas
            medidas.NombreCliente = cliente.nombre;

            _context.Medidas.Add(medidas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedidas", new { id = medidas.Id }, medidas);
        }


        // DELETE: api/Medidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedidas(int id)
        {
            var medidas = await _context.Medidas.FindAsync(id);
            if (medidas == null)
            {
                return NotFound();
            }

            _context.Medidas.Remove(medidas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedidasExists(int id)
        {
            return _context.Medidas.Any(e => e.Id == id);
        }
    }
}
