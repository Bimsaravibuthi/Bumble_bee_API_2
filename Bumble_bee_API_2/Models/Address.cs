using Bumble_bee_API_2.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Models
{
    public class Address
    {
        public int ADD_ID { get; set; }
        [Required]
        public string? ADD_MOBILE { get; set; }
        [Required]
        public string? ADD_NAME { get; set; }
        [Required]
        public string? ADD_LINE1 { get; set; }
        public string? ADD_LINE2 { get; set; }
        [Required]
        public int CITY { get; set; }
        [Required]
        public int USER { get; set; }
    }
}
