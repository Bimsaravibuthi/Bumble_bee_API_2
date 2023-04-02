using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using static Bumble_bee_API_2.Database.DatabaseContext;

namespace Bumble_bee_API_2.DAL
{
    public class DA_User
    {
        DatabaseContext _connection = new();
        StatusCode statusCodes = new();
        public List<tbl_User> GetUser(int? userId)
        {
            List<tbl_User> Users = new();

            try
            {
                var result = _connection.Tbl_Users?.FromSqlRaw("GetUser {0}", userId).ToList();
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
        public StatusCode AddUser(tbl_User us)
        {
            try
            {
                if (us.USR_TYPE != null && us.USR_NIC != null && us.USR_FNAME != null && us.USR_LNAME != null
                    && us.USR_EMAIL != null && us.USR_PWD != null)
                {
                    var result = _connection.statusCodes?.FromSqlRaw("AddUser {0},{1},{2},{3},{4},{5},{6}",
                    us.USR_TYPE, us.USR_NIC, us.USR_FNAME, us.USR_LNAME, us.USR_EMAIL, us.USR_PWD, us.USR_STATUS);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            statusCodes = item;
                        }
                        return statusCodes;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
        public StatusCode PatchUser(int userId, JsonPatchDocument tbl_User)
        {
            try
            {
                var user = _connection.Tbl_Users?.Find(userId);

                if (user != null)
                {
                    tbl_User.ApplyTo(user);
                    int result = _connection.SaveChanges();
                    if (result > 0)
                    {
                        statusCodes.STATUS_MSG = "PATCHED SUCCESSFULLY";
                    }
                    else
                    {
                        statusCodes.STATUS_MSG = "PATCHING UN-SUCCESSFUL";
                    }
                }
                return statusCodes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
        public StatusCode UpdateUser(tbl_User us)
        {
            try
            {
                if (us.USR_TYPE != null && us.USR_NIC != null && us.USR_FNAME != null && us.USR_LNAME != null
                && us.USR_EMAIL != null && us.USR_PWD != null)
                {
                    var result = _connection.statusCodes?.FromSqlRaw("UpdateUser {0},{1},{2},{3},{4},{5},{6},{7}",
                    us.USR_TYPE, us.USR_NIC, us.USR_FNAME, us.USR_LNAME, us.USR_EMAIL, us.USR_PWD, us.USR_STATUS, us.USR_ID);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            statusCodes = item;
                        }
                        return statusCodes;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
    }
}
