using Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Api.Models;
using Solid.Core.Services;
using Solid.Service;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using static System.Reflection.Metadata.BlobBuilder;
 
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowsController : ControllerBase
    {

        private readonly IBorrowService _borrowService;
        public BorrowsController(IBorrowService borrowService)
        {
            _borrowService = borrowService;
        }

        // GET: api/<BorrowsController>
        [HttpGet]
        public IEnumerable<Borrow> Get()
        {
            return _borrowService.GetAllBorrows();
        }

        // GET api/<BorrowsController>/5
        [HttpGet("{id}")]
        public Borrow Get(int id)
        {
            return _borrowService.GetById(id);
            
        }

        // POST api/<BorrowsController>
        [HttpPost]
        public void Post([FromBody] BorrowsPostModel value)
        {
            var borrowToAdd= new Borrow{Id=value.Id, Status =value.Status,Date=value.Date};
            _borrowService.Add(borrowToAdd);
        }

        // PUT api/<BorrowsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Borrow value)
        {
               _borrowService.Put(id,value);
        }
        // PUT api/<BorrowsController>/5
        [HttpPut("{id}/status")]
        public void PutStats(int id)
        { 
            _borrowService.PutStatus(id);
  
        }

      
    }
}
