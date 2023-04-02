using Bumble_bee_API_2.BLL;
using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Bumble_bee_API_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        BL_Category _bL_Category = new();

        [HttpGet("GetCategory(s)")]
        public IActionResult GetCategory(int? categoryId)
        {
            var result = _bL_Category.GetCategory(categoryId);
            if (result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }
        [HttpPost("AddCategory")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            var OPState = _bL_Category.AddCategory(category);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPatch("PatchCategory")]
        public IActionResult PatchCategory(int categoryId, [FromBody] JsonPatchDocument tbl_Category)
        {
            var OPState = _bL_Category.PatchCategory(categoryId, tbl_Category);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory([FromBody] Category category)
        {
            var OPState = _bL_Category.UpdateCategory(category);
            if (OPState != null)
            {
                return Ok(OPState);
            }
            return NoContent();
        }
    }
}
