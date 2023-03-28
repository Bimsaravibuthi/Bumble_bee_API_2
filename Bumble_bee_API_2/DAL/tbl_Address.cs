using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.DAL
{
    public class tbl_Address
    {
        [Key]
        public int ADD_ID { get; set; }
        [Required]
        public int ADD_MOBILE { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string? ADD_NAME { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string? ADD_LINE1 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ADD_LINE2 { get; set; }
        [Required]
        public tbl_City? CITY { get; set; }
        [Required]
        public tbl_User? USER { get; set; }
    }
}
