using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.Database
{
    [Keyless]
    public class tbl_UserProduct
    {
        public int UPDATE_USER { get; set; }
        public tbl_User? tbl_User { get; set; }
        public int PRODUCT_ID { get; set; }
        public tbl_Product? tbl_Product { get; set; }
        [Required]
        public DateTime UPDATE_DATE { get; set; }
        [Required]
        public string? UPDATE_DESC { get; set; }
    }
}
