using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get()
        {
            return BadRequest("Invalid input");
        }
     }
}

