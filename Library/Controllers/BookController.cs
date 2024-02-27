using Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Api.Models;
using Solid.Core.Services;
using Solid.Service;
 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookService.GetAllBooks();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
           return _bookService.GetById(id);
             
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book b)
        {    
            _bookService.Add(b);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            Book b = _bookService.GetById(id);
            if (b != null)
               _bookService.Put(id, value);

        }
        // PUT api/<BooksController>/5
        [HttpPut("{id}/status")]
        public void PutStatus(int id)
        {
            Book b = _bookService.GetById(id);
            if (b != null)
                _bookService.PutStatus(id);

        }
        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Book b = _bookService.GetById(id);
            if (b != null)
                 _bookService.Delete(id);
        }
    }
}
