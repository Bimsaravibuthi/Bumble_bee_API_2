using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.DAL
{
    [Keyless]
    public class tbl_UserProduct
    {
        public int USER_ID { get; set; }
        public tbl_User? tbl_User { get; set; }
        public int PRODUCT_ID { get; set; }
        public tbl_Product? tbl_Product { get; set; }
        public int ADDED_USER { get; set; }
        public int UPDATE_USER { get; set; }
    }
}
