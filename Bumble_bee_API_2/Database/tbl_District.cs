using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Database
{
    public class tbl_District
    {
        [Key]
        public int DT_ID { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        [Required]
        public string? DT_NAME { get; set; }
        public List<tbl_City>? CITY { get; set; }
    }
}
