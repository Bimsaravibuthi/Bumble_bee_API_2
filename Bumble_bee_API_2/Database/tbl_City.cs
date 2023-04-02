using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Database
{
    public class tbl_City
    {
        [Key]
        public int CT_ID { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [Required]
        public string? CT_NAME { get; set; }
        public ICollection<tbl_Address>? Tbl_Addresses { get; set; }
        [ForeignKey("Tbl_District")]
        public int DT_ID { get; set; }
        public tbl_District? Tbl_District { get; set; }
    }
}
