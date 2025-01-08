using Microsoft.AspNetCore.Mvc;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLessons.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingLesson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideContoller : ControllerBase
    {
        readonly IGuideService _guideService;
        public GuideContoller(IGuideService guideService)
        {
            _guideService = guideService;
        }



        // GET: api/<GuideContoller>
        [HttpGet]
        public ActionResult<List<Guide>> Get()
        {
            return _guideService.GetGuides();
        }

        // GET api/<GuideController>/5
        [HttpGet("{id}")]
        public ActionResult<Guide> Get(int id)
        {
            if (_guideService.GetGuideByCode(id) == default)
                return NotFound();
            return Ok(_guideService.GetGuideByCode(id));
        }

        // POST api/<GuideController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Guide guide)
        {
            if (_guideService.AddGuide(guide))
                return Ok();
            return BadRequest();///////////////////////////////////////////////
        }

        // PUT api/<GuideController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Guide guide)
        {
            if (_guideService.UpdateGuide(id, guide))
                return Ok();
            return NotFound();
        }
        // DELETE api/<GuideController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_guideService.DeleteGuide(id))
                return Ok();
            return NotFound();
        }
    }
}
