using Microsoft.AspNetCore.Mvc;

namespace MyTestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string value)
        {
            var result = $"{value} was the param";
            return Ok(result);
        }
    }
}
