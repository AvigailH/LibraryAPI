using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IBookService
    {
        public void Delete(int id);
        IEnumerable<Book> GetAllBooks();
        Book GetById(int id);
        public void Put(int id, Book value);
        public void PutStatus(int id);
        public void Add(Book value);
    }
}
