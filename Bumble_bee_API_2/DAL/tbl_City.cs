using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.DAL
{
    public class tbl_City
    {
        [Key]
        public int CT_ID { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [Required]
        public string? CT_NAME { get; set; }
        public List<tbl_Address>? ADDRESS { get; set; }
        public tbl_District? DISTRICT { get; set; }
    }
}
