using Microsoft.AspNetCore.Mvc;

namespace FrenCircle.Base.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "get")]
        public async Task<IActionResult> Get()
        {
            return Ok("it works");
        }
    }
}
