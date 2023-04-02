using Bumble_bee_API_2.Database;
using Microsoft.EntityFrameworkCore;
using static Bumble_bee_API_2.Database.DatabaseContext;

namespace Bumble_bee_API_2.DAL
{
    public class DA_Login
    {
        DatabaseContext _Connection = new();      
        public Login Login(string email)
        {
            Login login = new();
            var result = _Connection.Logins?.FromSqlRaw("GetLogin {0}", email);
            if(result != null)
            {
                foreach(var item in result)
                {
                    login = item;
                }
                return login;
            }
            return new Login();
        }
    }
}
