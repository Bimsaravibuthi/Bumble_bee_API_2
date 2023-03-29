using Bumble_bee_API_2.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Models
{
    public class Product
    {
        public int PR_ID { get; set; }
        [Required]
        public string? PR_NAME { get; set; }
        [Required]
        public string? PR_DESCRIPTION { get; set; }
        [Required]
        public string? PR_PRICE { get; set; }
        [Required]
        public string? PR_COST { get; set; }
        [Required]
        public int PR_QTY { get; set; }
        [Required]
        public int PR_ADDED_USER { get; set; }
        [Required]
        public DateTime PR_ADDED_DATE { get; set; }
        public Byte[]? PR_IMAGE { get; set; }
        [Required]
        public int BRAND { get; set; }
        [Required]
        public int CATEGORY { get; set; }
    }
}
