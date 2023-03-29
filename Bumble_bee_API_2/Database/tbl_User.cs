using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Database
{
    public class tbl_User
    {
        [Key]
        public int USR_ID { get; set; }
        [Column(TypeName = "nvarchar(2)")]
        [Required]
        public string? USR_TYPE { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [Required]
        public string? USR_NIC { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string? USR_FNAME { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string? USR_LNAME { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [Required]
        public string? USR_EMAIL { get; set; }
        [Column(TypeName = "varbinary(MAX)")]
        [Required]
        public byte[]? USR_PWD { get; set; }
        [Required]
        public bool USR_STATUS { get; set; }
        public ICollection<tbl_Address>? ADDRESS { get; set; }
        public ICollection<tbl_UserProduct>? tbl_UserProducts { get; set; }
    }
}
