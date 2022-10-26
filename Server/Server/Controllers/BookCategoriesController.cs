using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookCategoriesController : ControllerBase
    {
        private readonly MyContext _context;

        public BookCategoriesController(MyContext context)
        {
            _context = context;
        }

        // GET: api/BookCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookCategories>>> GetBooksCategories()
        {
            return await _context.BooksCategories.ToListAsync();
        }

        // POST: api/BookCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookCategories>> PostBookCategories(BookCategories bookCategories)
        {
            _context.BooksCategories.Add(bookCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookCategories", new { id = bookCategories.BookCategoriesID }, bookCategories);
        }

        /*
        // GET: api/BookCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookCategories>> GetBookCategories(int id)
        {
            var bookCategories = await _context.BooksCategories.FindAsync(id);

            if (bookCategories == null)
            {
                return NotFound();
            }

            return bookCategories;
        }

        // PUT: api/BookCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookCategories(int id, BookCategories bookCategories)
        {
            if (id != bookCategories.BookCategoriesID)
            {
                return BadRequest();
            }

            _context.Entry(bookCategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookCategoriesExists(id))
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

        // POST: api/BookCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookCategories>> PostBookCategories(BookCategories bookCategories)
        {
            _context.BooksCategories.Add(bookCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookCategories", new { id = bookCategories.BookCategoriesID }, bookCategories);
        }

        // DELETE: api/BookCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookCategories(int id)
        {
            var bookCategories = await _context.BooksCategories.FindAsync(id);
            if (bookCategories == null)
            {
                return NotFound();
            }

            _context.BooksCategories.Remove(bookCategories);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookCategoriesExists(int id)
        {
            return _context.BooksCategories.Any(e => e.BookCategoriesID == id);
        }
        */
    }
}
