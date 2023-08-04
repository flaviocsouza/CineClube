using Microsoft.AspNetCore.Mvc;

namespace CineClubeApp.Controllers
{
    [ApiController]
    [Route("api/init")]
    public class InitPlaceholderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Deu certo :)");
        }
        
    }
}