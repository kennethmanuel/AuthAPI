using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI
{
    [Route("api/testauth")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var userName = User.Identity.Name; // Get the authenticated user's name
            return Ok($"Hello 1234, {userName}");
        }

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok("Hello");
        }
    }
}
