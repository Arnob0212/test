using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtLoginAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("secret")]
        [Authorize]
        public IActionResult GetSecret()
        {
            return Ok("You have accessed a protected endpoint!");
        }
    }
}
