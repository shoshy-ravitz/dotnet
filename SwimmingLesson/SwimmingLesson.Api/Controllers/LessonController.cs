using Microsoft.AspNetCore.Mvc;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLessons.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingLesson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        readonly ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }


        // GET: api/<LessonController>
        [HttpGet]
        public IEnumerable<Lesson> Get()
        {
            return _lessonService.GetLessons();
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Lesson> Get(int id)
        {
            if (_lessonService.GetLessonByCode(id) == default)
                return NotFound();
            return Ok(_lessonService.GetLessonByCode(id));
        }

        // POST api/<LessonController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Lesson lesson)
        {
            if (_lessonService.AddLesson(lesson))
                return Ok();
            return NotFound();
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Lesson lesson)
        {
            if (_lessonService.UpdateLesson(id, lesson))
                return Ok();
            return NotFound();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_lessonService.DeleteLesson(id))
                return Ok();
            return NotFound();
        }
    }
}
