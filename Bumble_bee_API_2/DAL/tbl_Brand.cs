using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.DAL
{
    public class tbl_Brand
    {
        [Key]
        public int BR_ID { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        [Required]
        public string? BR_NAME { get; set; }
        public ICollection<tbl_Product>? PRODUCT { get; set; }
    }
}
