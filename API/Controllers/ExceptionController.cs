using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExceptionController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            throw new System.Exception("Error");
        }
    }
}
