using Bumble_bee_API_2.Database;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Models
{
    public class UserProduct
    {
        [Required]
        public int UPDATE_USER { get; set; }
        [Required]
        public int PRODUCT_ID { get; set; }
        [Required]
        public DateTime UPDATE_DATE { get; set; }
        [Required]
        public string? UPDATE_DESC { get; set; }
    }
}
