using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities;
using static System.Net.Mime.MediaTypeNames;
using Solid.Core.Services;

namespace Solid.Service
{
    public class BookService: IBookService
    {
        private readonly IBookRepository _bookRepository; 
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        } 
        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            //לוגיקה עסקית
            //var books = _bookRepository.GetBooks();

            //return books.Where(u => u.Name.Contains(text));
            return _bookRepository.GetBooks();
        }
        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void Put(int id, Book value)
        {
             _bookRepository.Put(id, value);


        }

        public void PutStatus(int id)
        {

            _bookRepository.PutStatus(id);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }
    }

}
