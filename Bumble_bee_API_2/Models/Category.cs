using Bumble_bee_API_2.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Models
{
    public class Category
    {
        [Key]
        public int CAT_ID { get; set; }
        [Required]
        public string? CAT_NAME { get; set; }
    }
}
