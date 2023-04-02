using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.Database
{
    public class tbl_Product
    {
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
        [Column(TypeName = "nvarchar(7)")]
        [Required]
        public string? PR_COST { get; set; }
        public int PR_QTY { get; set; }
        [Required]
        public int PR_ADDED_USER { get; set; }
        [Required]
        public DateTime PR_ADDED_DATE { get; set; }
        [Column(TypeName ="varbinary(MAX)")]
        public Byte[]? PR_IMAGE { get; set; }
        public ICollection<tbl_UpdateProduct>? Tbl_UpdateProducts { get; set; }
        [ForeignKey("Tbl_Brand")]
        public int BR_ID { get; set; }
        public tbl_Brand? Tbl_Brand { get; set; }
        [ForeignKey("Tbl_Category")]
        public int CAT_ID { get; set; }
        public tbl_Category? Tbl_Category { get; set; }
    }
}
