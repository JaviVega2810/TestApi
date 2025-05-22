using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("testing")]
        public IActionResult GetTestingData()
        {
            _logger.LogInformation("API executed succesfully...");

            return Ok();
        }
    }
}
