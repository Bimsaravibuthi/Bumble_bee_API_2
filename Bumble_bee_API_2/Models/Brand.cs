using Bumble_bee_API_2.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Models
{
    public class Brand
    {
        public int BR_ID { get; set; }
        [Required]
        public string? BR_NAME { get; set; }
    }
}
