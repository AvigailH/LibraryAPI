using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IBorrowService
    {
         IEnumerable<Borrow> GetAllBorrows();
        Borrow GetById(int id);
       public void Put(int id, Borrow value);
        public void PutStatus(int id);
        public void Delete(int id);
        public void Add(Borrow value);
    }
}



