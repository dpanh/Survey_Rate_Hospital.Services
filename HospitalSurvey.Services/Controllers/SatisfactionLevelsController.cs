using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalSurvey.Data.EF;
using HospitalSurvey.Data.Entities;

namespace HospitalSurvey.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatisfactionLevelsController : ControllerBase
    {
        private readonly HospitalSurveyDbContext _context;

        public SatisfactionLevelsController(HospitalSurveyDbContext context)
        {
            _context = context;
        }

        // GET: api/SatisfactionLevels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SatisfactionLevel>>> GetSatisfactionLevels()
        {
            return await _context.SatisfactionLevels.ToListAsync();
        }

        // GET: api/SatisfactionLevels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SatisfactionLevel>> GetSatisfactionLevel(int id)
        {
            var satisfactionLevel = await _context.SatisfactionLevels.FindAsync(id);

            if (satisfactionLevel == null)
            {
                return NotFound();
            }

            return satisfactionLevel;
        }

        // PUT: api/SatisfactionLevels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSatisfactionLevel(int id, SatisfactionLevel satisfactionLevel)
        {
            if (id != satisfactionLevel.Id)
            {
                return BadRequest();
            }

            _context.Entry(satisfactionLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SatisfactionLevelExists(id))
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

        // POST: api/SatisfactionLevels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SatisfactionLevel>> PostSatisfactionLevel(SatisfactionLevel satisfactionLevel)
        {
            _context.SatisfactionLevels.Add(satisfactionLevel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSatisfactionLevel", new { id = satisfactionLevel.Id }, satisfactionLevel);
        }

        // DELETE: api/SatisfactionLevels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SatisfactionLevel>> DeleteSatisfactionLevel(int id)
        {
            var satisfactionLevel = await _context.SatisfactionLevels.FindAsync(id);
            if (satisfactionLevel == null)
            {
                return NotFound();
            }

            _context.SatisfactionLevels.Remove(satisfactionLevel);
            await _context.SaveChangesAsync();

            return satisfactionLevel;
        }

        private bool SatisfactionLevelExists(int id)
        {
            return _context.SatisfactionLevels.Any(e => e.Id == id);
        }
    }
}
