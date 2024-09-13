using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCodeSnippets.Data;
using ApiCodeSnippets.Models;

namespace ApiCodeSnippets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeSnippetsController : ControllerBase
    {
        private readonly CodeSnippetsContext _context;

        public CodeSnippetsController(CodeSnippetsContext context)
        {
            _context = context;
        }

        // GET: api/CodeSnippets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CodeSnippet>>> GetCodeSnippet()
        {
          if (_context.CodeSnippet == null)
          {
              return NotFound();
          }
            return await _context.CodeSnippet.ToListAsync();
        }

        // GET: api/CodeSnippets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CodeSnippet>> GetCodeSnippet(int id)
        {
          if (_context.CodeSnippet == null)
          {
              return NotFound();
          }
            var codeSnippet = await _context.CodeSnippet.FindAsync(id);

            if (codeSnippet == null)
            {
                return NotFound();
            }

            return codeSnippet;
        }

        // PUT: api/CodeSnippets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodeSnippet(int id, CodeSnippet codeSnippet)
        {
            if (id != codeSnippet.Id)
            {
                return BadRequest();
            }

            _context.Entry(codeSnippet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeSnippetExists(id))
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

        // POST: api/CodeSnippets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CodeSnippet>> PostCodeSnippet(CodeSnippet codeSnippet)
        {
          if (_context.CodeSnippet == null)
          {
              return Problem("Entity set 'CodeSnippetsContext.CodeSnippet'  is null.");
          }
            _context.CodeSnippet.Add(codeSnippet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCodeSnippet", new { id = codeSnippet.Id }, codeSnippet);
        }

        // DELETE: api/CodeSnippets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCodeSnippet(int id)
        {
            if (_context.CodeSnippet == null)
            {
                return NotFound();
            }
            var codeSnippet = await _context.CodeSnippet.FindAsync(id);
            if (codeSnippet == null)
            {
                return NotFound();
            }

            _context.CodeSnippet.Remove(codeSnippet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CodeSnippetExists(int id)
        {
            return (_context.CodeSnippet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
