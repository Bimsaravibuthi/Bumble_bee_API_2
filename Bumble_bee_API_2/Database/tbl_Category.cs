using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.Database
{
    public class tbl_Category
    {
        [Key]
        public int CAT_ID { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        [Required]
        public string? CAT_NAME { get; set; }
        public ICollection<tbl_Product>? PRODUCTS { get; set; }
    }
}
