using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Bumble_bee_API_2.DAL
{
    public class DA_User
    {
        DatabaseContext _connection = new();
        public List<tbl_User> GetUser(int? userId)
        {
            List<tbl_User> Users = new();

            try
            {
                var result = _connection.tbl_Users?.FromSqlRaw("GetUser {0}", userId).ToList();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        tbl_User tbl_User = new();
                        tbl_User.USR_ID = item.USR_ID;
                        tbl_User.USR_FNAME = item.USR_FNAME;
                        tbl_User.USR_LNAME = item.USR_LNAME;
                        tbl_User.USR_EMAIL = item.USR_EMAIL;
                        tbl_User.USR_STATUS = item.USR_STATUS;
                        tbl_User.USR_PWD = item.USR_PWD;
                        tbl_User.USR_NIC = item.USR_NIC;
                        tbl_User.USR_TYPE = item.USR_TYPE;
                        Users.Add(tbl_User);
                    }
                    return Users;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new List<tbl_User>();
        }
        public object AddUser(tbl_User us)
        {
            int OPState = 0;
            try
            {
                if (us.USR_TYPE != null && us.USR_NIC != null && us.USR_FNAME != null && us.USR_LNAME != null
                    && us.USR_EMAIL != null && us.USR_PWD != null)
                {
                    OPState = _connection.Database.ExecuteSqlRaw("AddUser {0},{1},{2},{3},{4},{5},{6}",
                    us.USR_TYPE,us.USR_NIC,us.USR_FNAME,us.USR_LNAME,us.USR_EMAIL,us.USR_PWD,us.USR_STATUS);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return OPState;
        }
    }
}
