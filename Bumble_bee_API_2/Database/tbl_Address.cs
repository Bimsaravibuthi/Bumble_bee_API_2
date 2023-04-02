using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Database
{
    public class tbl_Address
    {
        [Key]
        public int ADD_ID { get; set; }
        [Column(TypeName ="nvarchar(10)")]
        [Required]
        public string? ADD_MOBILE { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string? ADD_NAME { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string? ADD_LINE1 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ADD_LINE2 { get; set; }
        [ForeignKey("Tbl_City")]
        public int CT_ID { get; set; }
        public tbl_City? Tbl_City { get; set; }
        [ForeignKey("Tbl_User")]
        public int USR_ID { get; set; }
        public tbl_User? Tbl_User { get; set; }
    }
}
