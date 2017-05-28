using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Produces("application/json")]
    [Route("api/HealthCheck")]
    public class HealthCheckController : Controller
    {
        public IActionResult Get()
        {
            return Ok(new HelloWorldResponse<string>
            {
                IsSuccessful = true,
                Body = "Hello World"
            });
        }

        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new HelloWorldResponse<string>
            {
                IsSuccessful = true,
                Body = $"Hello World, {id}"
            });
        }
    }
}
