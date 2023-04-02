using Bumble_bee_API_2.BLL;
using Bumble_bee_API_2.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bumble_bee_API_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        BL_Login _bL_Login = new();

        [HttpGet("Login")]
        public IActionResult Login(string loginCredential)
        {    
            var result = _bL_Login.Login(loginCredential);
            if(result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }
    }
}
