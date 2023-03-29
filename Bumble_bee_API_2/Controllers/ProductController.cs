using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bumble_bee_API_2.BLL;

namespace Bumble_bee_API_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProduct(s)")]
        public IActionResult GetProduct(int? productId) 
        {
            BL_Product _bL_Product = new();
            var result = _bL_Product.GetProduct(productId);
            if(result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }
    }
}
