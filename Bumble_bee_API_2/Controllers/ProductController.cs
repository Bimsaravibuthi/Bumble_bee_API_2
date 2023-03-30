using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bumble_bee_API_2.BLL;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Bumble_bee_API_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        BL_Product _bL_Product = new();

        [HttpGet("GetProduct(s)")]
        public IActionResult GetProduct(int? productId) 
        {          
            var result = _bL_Product.GetProduct(productId);
            if(result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            int OPState = _bL_Product.AddProduct(product);
            if(OPState > 0) 
            {
                return Ok("Product inserted successfully.");
            }
            return Problem("Product insertion un-successful.");
        }
        [HttpPatch("PatchProduct")]
        public IActionResult PatchProduct(int productId, int userId, string updateDesc, [FromBody] JsonPatchDocument tbl_Product)
        {
            int OPState = _bL_Product.PatchProduct(productId, userId, updateDesc, tbl_Product);
            if(OPState > 0) 
            {
                return Ok("Product patched successfully.");
            }
            return Problem("Product patching un-successful.");
        }
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product product, int userId, string updateDesc)
        {
            int OPState = _bL_Product.UpdateProduct(product, userId, updateDesc);
            if(OPState > 0)
            {
                return Ok("Product updated successfully.");
            }
            return Problem("Product updating un-successful.");
        }
    }
}
