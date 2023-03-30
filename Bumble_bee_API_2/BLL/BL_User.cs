using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
namespace Bumble_bee_API_2.BLL
{
    public class BL_User
    {
        DA_User _dA_User = new();
        public List<User> GetUser(int? userId)
        {
            List<User> users = new();
            var result = _dA_User.GetUser(userId);
            foreach (var item in result)
            {
                User user = new User();
                user.USR_ID = item.USR_ID;
                user.USR_PWD = item.USR_PWD;
                user.USR_LNAME = item.USR_LNAME;
                user.USR_FNAME = item.USR_FNAME;
                user.USR_STATUS = item.USR_STATUS;
                user.USR_NIC = item.USR_NIC;
                user.USR_EMAIL = item.USR_EMAIL;
                user.USR_TYPE = item.USR_TYPE;
                users.Add(user);
            }
            return users;
        }
        public object AddUser(User user)
        {
            tbl_User tbl_User = new()
            {
                USR_PWD = user.USR_PWD,
                USR_LNAME = user.USR_LNAME,
                USR_FNAME = user.USR_FNAME,
                USR_STATUS = user.USR_STATUS,
                USR_NIC = user.USR_NIC,
                USR_EMAIL = user.USR_EMAIL,
                USR_TYPE = user.USR_TYPE
            };
            var OPState = _dA_User.AddUser(tbl_User);
            return OPState;
        }
    }
}
