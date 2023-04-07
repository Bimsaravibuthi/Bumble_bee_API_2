using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bumble_bee_API_2.Models
{
    public class User
    {
        public int USR_ID { get; set; }
        [Required(ErrorMessage = "User type is required")]
        [RegularExpression("(AD|CT)",ErrorMessage = "Provided data is not valid")]
        public string? USR_TYPE { get; set; }
        [Required(ErrorMessage = "User NIC number is required")]
        [RegularExpression("^\\d{12}$|^\\d{9}[VX]$", ErrorMessage = "Provided NIC is not valid")]
        public string? USR_NIC { get; set; }
        [Required(ErrorMessage = "User first name is required")]
        public string? USR_FNAME { get; set; }
        [Required(ErrorMessage = "User last name is required")]
        public string? USR_LNAME { get; set; }
        [Required(ErrorMessage = "User email address is required")]
        [EmailAddress(ErrorMessage = "Provided email address is not valid")]
        public string? USR_EMAIL { get; set; }
        [Required(ErrorMessage = "User password is required")]
        public string? USR_PWD { get; set; }
        public bool USR_STATUS { get; set; }
    }
}
