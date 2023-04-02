using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.Database
{
    public class tbl_UpdateProduct
    {
        [Key]
        public int UPDATE_ID { get; set; }
        [ForeignKey("Tbl_User")]
        public int USR_ID { get; set; }
        public tbl_User? Tbl_User { get; set; }
        [ForeignKey("Tbl_Product")]
        public int PR_ID { get; set; }
        public tbl_Product? Tbl_Product { get; set; }
        [Required]
        public DateTime UPDATE_DATE { get; set; }
        [Required]
        public string? UPDATE_DESC { get; set; }
    }
}
