using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.DAL
{
    public class tbl_User
    {
        public tbl_User()
        {
            this.PRODUCT = new List<tbl_Product>();
        }

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
        public bool CUS_STATUS { get; set; }
        public List<tbl_Address>? ADDRESS { get; set; }
        public List<tbl_Product>? PRODUCT { get; set; }
    }
}
