using Bumble_bee_API_2.BLL;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Bumble_bee_API_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        BL_Brand _bL_Brand = new();

        [HttpGet("GetBrand(s)")]
        public IActionResult GetBrand(int? brandId)
        {
            var result = _bL_Brand.GetBrand(brandId);
            if(result != null)
            {
               return Ok(result);
            }
            return NoContent();
        }
        [HttpPost("AddBrand")]
        public IActionResult AddBrand([FromBody] Brand brand)
        {
            var OPState = _bL_Brand.AddBrand(brand);
            if(OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPatch("PatchBrand")]
        public IActionResult PatchBrand(int brandid,[FromBody] JsonPatchDocument tbl_Brand)
        {
            var OPState = _bL_Brand.PatchBrand(brandid, tbl_Brand);
            if(OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPut("UpdateBrand")]
        public IActionResult UpdateBrand([FromBody] Brand brand)
        {
            var OPState = _bL_Brand.UpdateBrand(brand);
            if(OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
    }
}
