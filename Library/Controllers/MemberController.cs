using Microsoft.AspNetCore.Mvc;
 using Microsoft.Extensions.Logging;
using Solid.Service;
using Library.Entities;
using Solid.Core.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//לקוח יכול לשאול ספר כמה פעמים!
//בגלל זה לא צריך מפתח יחודי של ספר  ומשאיל
namespace Solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        //static int id = 1;
        //static List<Member> members=new List<Member> { new Member(id++,"moshe",true), new Member(id++, "haim",true) , new Member(id++, "tuvia", true) };
        private readonly IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }


        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return _memberService.GetAllMembers();
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            Member m = _memberService.GetById(id);
            if (m != null)
                return m;
            return null;
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] Member value)
        {
            _memberService.GetAllMembers().Append(new Member(value.Name, true, value.Tel));
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Member value)
        {
            Member m = _memberService.GetById(id);
            if (m != null)
                 
            
            //m.Name = value.Name;
            //m.Tel = value.Tel;
            //m.Status = value.Status;

            //_memberService.GetAllMembers().Append(m);
              _memberService.Put(id,value);

        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Member m = _memberService.GetById( id);
            if (m != null)
                _memberService.Delete(id);
        }
    }//[HttpPut("{id}/status")]
     //public ActionResult PutStatus(int id)
     //{
     //    Member m = members.Find(member => member.Id == id);
     //    if (m == null)
     //        return NotFound();
     //    members.Remove(m);
     //    m.Status = !m.Status;
     //    members.Add(m);
     //    return Ok();
     //}
}
