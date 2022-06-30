using Client.Models;

using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IEnumerable<Demo> demoList;

        public DemoController()
        {
            demoList = Enumerable.Range(0, 3).Select(x => new Demo("demo" + x));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Demo>> Get()
        {
            return Ok(demoList);
        }

        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Demo> Get(string name)
        {
            var found = demoList.SingleOrDefault(x => x.Name == name);

            if (found is null) {
                return NotFound();
            }

            return Ok(found);
        }
    }
}
