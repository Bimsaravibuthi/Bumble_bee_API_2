using Bumble_bee_API_2.BLL;
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
            var OPState = _bL_User.AddUser(user);
            if(Convert.ToInt32(OPState) > 0)
            {
                return Ok("User inserted successfully.");
            }
            return Problem("User insertion un-successful.");
        }
        [HttpPatch("PatchUser")]
        public IActionResult PatchUser(int userId, [FromBody] JsonPatchDocument tbl_User) 
        {
            var OPState = _bL_User.PatchUser(userId, tbl_User);
            if (Convert.ToInt32(OPState) > 0)
            {
                return Ok("User patched successfully.");
            }
            return Problem("User patching un-successful.");
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            var OPState = _bL_User.UpdateUser(user);
            if (Convert.ToInt32(OPState) > 0)
            {
                return Ok("User updated successfully.");
            }
            return Problem("User update un-successful.");
        }
    }
}
