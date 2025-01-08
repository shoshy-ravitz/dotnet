using Microsoft.AspNetCore.Mvc;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLessons.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingLesson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }


        // GET: api/<GroupController>
        [HttpGet]
        public ActionResult<List<Group>> Get()
        {
            return _groupService.GetGroups();
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public ActionResult<Group> Get(int code)
        {
            if (_groupService.GetGroupByCode(code) == default)
                return NotFound();
            return Ok(_groupService.GetGroupByCode(code));
        }

        // POST api/<GroupController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Group group)
        {
            if (group == null) return Unauthorized();
            if (_groupService.AddGroup(group))
                return Ok();
            return NotFound();
        }
        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Group group)
        {
            if (group == null) Unauthorized();
            if (_groupService.UpdateGroup(id, group))
                return Ok();
            return NotFound();

        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_groupService.DeleteGroup(id))
                return Ok();
            return NotFound();
        }
    }
}
