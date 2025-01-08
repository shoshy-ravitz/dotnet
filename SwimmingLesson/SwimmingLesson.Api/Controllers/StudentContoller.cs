using Microsoft.AspNetCore.Mvc;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLesson.Service.Services;
using SwimmingLessons.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingLesson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentContoller : ControllerBase
    {
        readonly IStudentService _studentService;

        public StudentContoller(IStudentService studentService)
        {
            _studentService = studentService;
        }



        // GET: api/<StudentContoller>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentService.GetStudents();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return _studentService.GetStudentByCode(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Student student)
        {
            return _studentService.AddStudent(student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int Code, [FromBody] Student student)
        {
            if (_studentService.UpdateStudent(Code, student))
                return Ok();
            return NotFound();
        }
        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_studentService.DeleteStudent(id))
                return Ok();
            return NotFound();
        }
    }
}
