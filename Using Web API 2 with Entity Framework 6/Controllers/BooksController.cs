using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Using_Web_API_2_with_Entity_Framework_6.Models;

namespace Using_Web_API_2_with_Entity_Framework_6.Controllers
{
    public class BooksController : ApiController
    {
        private BookServiceContext db = new BookServiceContext();

        // GET: api/Books
        [Route("api/AllBooks")]
        public IQueryable<Book> GetAllBooks()
        {
            return db.Books.Include(b => b.Author);
        }

        public IQueryable<BookDTO> GetBooks()
        {
            List<Book> test = db.Books.Include(b => b.Author).ToList();
            var books = from b in db.Books.Include(x => x.Author)
                        select new BookDTO()
                        {
                            intId = b.Id,
                            strTitle = b.strTitle,
                            strAuthorName = b.Author.strName
                        };
            return books;
            //return db.Books.Include(x => x.Author); //eager loading: join xong return
        }

        // GET: api/Books/5
        [ResponseType(typeof(BookDetailDTO))]
        public async Task<IHttpActionResult> GetBook(int id)
        {
            var book = await db.Books.Include(x => x.Author)
                .Select(b => new BookDetailDTO()
                {
                    intId = b.Id,
                    strTitle = b.strTitle,
                    intYear = b.intYear,
                    decPrice = b.decPrice,
                    strAuthorName = b.Author.strName,
                    strGenre = b.strGenre
                }).SingleOrDefaultAsync(b => b.intId == id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // PUT: api/Books/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBook(int id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != book.Id)
            {
                return BadRequest();
            }

            db.Entry(book).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
                return Ok(db.Books);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Books
        [ResponseType(typeof(Book))]
        public IHttpActionResult PostBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Books.Add(book);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = book.Id }, book);
        }

        // DELETE: api/Books/5
        [ResponseType(typeof(Book))]
        public IHttpActionResult DeleteBook(int id)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            db.Books.Remove(book);
            db.SaveChanges();

            return Ok(book);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookExists(int id)
        {
            return db.Books.Count(e => e.Id == id) > 0;
        }
    }
}