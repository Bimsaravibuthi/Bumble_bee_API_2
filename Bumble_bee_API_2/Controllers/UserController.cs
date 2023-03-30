using Bumble_bee_API_2.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bumble_bee_API_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        BL_User _bL_User = new();

        [HttpGet("GetUser(s)")]
        public IActionResult GetUser(int? userId)
        {
            var result = _bL_User.GetUser(userId);
            if (result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }

    }
}
