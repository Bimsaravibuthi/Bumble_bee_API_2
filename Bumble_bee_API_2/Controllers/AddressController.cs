using Bumble_bee_API_2.BLL;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Bumble_bee_API_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        BL_Address _bL_Address = new();

        [HttpGet("GetAddress(s)")]
        public IActionResult GetAddress(int? userId, int? addressId)
        {
            var result = _bL_Address.GetAddress(userId, addressId);
            if (result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }
        [HttpPost("AddAddress")]
        public IActionResult AddAddress([FromBody] Address address)
        {
            var OPState = _bL_Address.AddAddress(address);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPatch("PatchAddress")]
        public IActionResult PatchAddress(int addressId, [FromBody] JsonPatchDocument tbl_Address)
        {
            var OPState = _bL_Address.PatchAddress(addressId, tbl_Address);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPut("UpdateAddress")]
        public IActionResult UpdateAddress([FromBody] Address address)
        {
            var OPState = _bL_Address.UpdateAddress(address);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
    }
}
