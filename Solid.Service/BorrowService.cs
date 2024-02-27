using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities;
using Solid.Core.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Solid.Service
{
    public class BorrowService:IBorrowService
    {
        private readonly IBorrowRepository _borrowRepository;
        public BorrowService(IBorrowRepository borrowRepository)
        {
            _borrowRepository = borrowRepository;
        }
        public void Add(Borrow b)
        {
            _borrowRepository.Add(b);
        }

        public IEnumerable<Borrow> GetAllBorrows()
        {
            return _borrowRepository.GetBorrows();
        }
        public Borrow GetById(int id)
        {
            return _borrowRepository.GetById(id);
        }

        public void Put(int id, Borrow value)
        {
              _borrowRepository.Put(id, value);


        }

        public void PutStatus(int id)
        {

            _borrowRepository.PutStatus(id);
        }

        public void Delete(int id)
        {
             _borrowRepository.Delete(id);
        }
    }
}
