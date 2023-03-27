using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.DAL
{
    public class tbl_Product
    {
        public tbl_Product() 
        {
            this.USERS = new List<tbl_User>();
        }

        [Key]
        public int PR_ID { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [Required]
        public string? PR_NAME { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string? PR_DESCRIPTION { get; set; }
        [Column(TypeName = "nvarchar(7)")]
        [Required]
        public string? PR_PRICE { get; set; }
        public List<tbl_User>? USERS { get; set; }
    }
}
