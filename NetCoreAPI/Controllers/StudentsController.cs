using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreAPI_DataFirst.Models;

namespace NetCoreAPI_DataFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly NETCoreSchoolContext _context;

        public StudentsController(NETCoreSchoolContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public IEnumerable<Students> GetStudents()
        {
            return _context.Students;
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudents([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var students = await _context.Students.FindAsync(id);

            if (students == null)
            {
                return NotFound();
            }

            return Ok(students);
        }

        // PUT: api/Students/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudents([FromRoute] int id, [FromBody] Students students)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != students.IntId)
            {
                return BadRequest();
            }

            _context.Entry(students).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsExists(id))
                {
                    return NotFound("Update failed");
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update success");
        }

        // PUT: api/Students/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PartialUpdateStudents([FromRoute] int id, [FromBody] JsonPatchDocument<Students> students)
        {
            var studentInstance = _context.Students.FirstOrDefault(x => x.IntId == id);
            try
            {
                students.ApplyTo(studentInstance);
                _context.Update(studentInstance);
                //await _context.SaveChangesAsync();
                studentInstance = _context.Students.FirstOrDefault(x => x.IntId == id);
            }
            catch(Exception ex)
            {
                return NotFound("Student doesn't exists");
            }
            return Ok(studentInstance);
        }

        // POST: api/Students
        [HttpPost]
        public async Task<IActionResult> PostStudents([FromBody] Students students)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Students.Add(students);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudents", new { id = students.IntId }, students);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudents([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var students = await _context.Students.FindAsync(id);
            if (students == null)
            {
                return NotFound();
            }

            _context.Students.Remove(students);
            await _context.SaveChangesAsync();

            return Ok(students);
        }

        private bool StudentsExists(int id)
        {
            return _context.Students.Any(e => e.IntId == id);
        }
    }
}