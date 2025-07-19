using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtLoginAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PolicyController : ControllerBase
    {
        [HttpGet("admin-data")]
        [Authorize(Policy = "AdminOnly")]
        public IActionResult GetAdminData()
        {
            return Ok("Only Admins can see this confidential admin data.");
        }
    }
}
