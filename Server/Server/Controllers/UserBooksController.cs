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
    public class UserBooksController : ControllerBase
    {
        private readonly MyContext _context;

        public UserBooksController(MyContext context)
        {
            _context = context;
        }

        // GET: api/UserBooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserBook>>> GetUserBooks()
        {
            return await _context.UserBooks.ToListAsync();
        }

        // POST: api/UserBooks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserBook>> PostUserBook(UserBook userBook)
        {
            _context.UserBooks.Add(userBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserBook", new { id = userBook.UserBookID }, userBook);
        }

        /*
        // GET: api/UserBooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserBook>> GetUserBook(int id)
        {
            var userBook = await _context.UserBooks.FindAsync(id);

            if (userBook == null)
            {
                return NotFound();
            }

            return userBook;
        }

        // PUT: api/UserBooks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserBook(int id, UserBook userBook)
        {
            if (id != userBook.UserBookID)
            {
                return BadRequest();
            }

            _context.Entry(userBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserBookExists(id))
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

        // POST: api/UserBooks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserBook>> PostUserBook(UserBook userBook)
        {
            _context.UserBooks.Add(userBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserBook", new { id = userBook.UserBookID }, userBook);
        }

        // DELETE: api/UserBooks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserBook(int id)
        {
            var userBook = await _context.UserBooks.FindAsync(id);
            if (userBook == null)
            {
                return NotFound();
            }

            _context.UserBooks.Remove(userBook);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserBookExists(int id)
        {
            return _context.UserBooks.Any(e => e.UserBookID == id);
        }
        */
    }
}
