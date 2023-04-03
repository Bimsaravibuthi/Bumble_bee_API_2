using Bumble_bee_API_2.BLL;
using Bumble_bee_API_2.Encryption;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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
        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            user.USR_PWD = MD5_Encryiption.Encrypt(user.USR_PWD);

            var OPState = _bL_User.AddUser(user);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPatch("PatchUser")]
        public IActionResult PatchUser(int userId, [FromBody] JsonPatchDocument tbl_User)
        {
            var OPState = _bL_User.PatchUser(userId, tbl_User);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            var OPState = _bL_User.UpdateUser(user);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
    }
}
