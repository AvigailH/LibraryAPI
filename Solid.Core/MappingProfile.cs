using AutoMapper;
using AutoMapper.Execution;
using Solid.Core.DTOb;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Solid.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Library.Entities.Member, MemberDto>().ReverseMap();
            CreateMap<Borrow, BorrowDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
