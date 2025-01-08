using Microsoft.AspNetCore.Mvc;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLessons.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingLesson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public List<Course> Get()
        {
            return _courseService.GetCourses();
        }
        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            if (_courseService.GetCourseByCode(id) == default)
                return NotFound();
            return Ok(_courseService.GetCourseByCode(id)); ;
        }
        // POST api/<CourseController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Course course)
        {
            if (_courseService.AddCourse(course))
                return Ok();
            return NotFound();
        }
        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Course course)
        {
            if (_courseService.UpdateCourse(id, course))
                return Ok();
            return NotFound();
        }
        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_courseService.DeleteCourse(id))
                return Ok();
            return NotFound();
        }
    }
}
