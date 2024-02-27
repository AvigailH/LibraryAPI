using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IMemberService
    {
        public void Delete(int id);
        public IEnumerable<Member> GetAllMembers();
        public Member GetById(int id);
        public void Put(int id, Member value);
    }
}
