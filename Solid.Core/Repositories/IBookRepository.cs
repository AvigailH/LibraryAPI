using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities;

namespace Solid.Core.Repositories
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks();

        public Book GetById(int id);

        public void Add(Book Book);
       // public Book Post(Book b);

        public void Put(int id, Book value);

        public void PutStatus(int id);
        public void Delete(int id);

    }
}
