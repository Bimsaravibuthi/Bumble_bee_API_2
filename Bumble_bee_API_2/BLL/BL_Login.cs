using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Encryption;
using Bumble_bee_API_2.Helpers;
using Bumble_bee_API_2.Security;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static Bumble_bee_API_2.Database.DatabaseContext;

namespace Bumble_bee_API_2.BLL
{
    public class BL_Login
    {
        DA_Login _dA_Login = new();
        public object Login(string loginCredential)
        {
            //loginCredential = EncryptAndDecrypt.DecryptString(loginCredential);
            string[] lcs = loginCredential.Split(new string[] { "<|SP|>" }, StringSplitOptions.None);

            Login login = _dA_Login.Login(lcs[0].Trim());
            if(login != null)
            {
                string asd = login.USR_PWD;
                string asf = MD5_Encryiption.Encrypt(lcs[1]);

                if (login.USR_PWD == MD5_Encryiption.Encrypt(lcs[1]))
                {
                    var claims = new[]
                    {
                        new Claim("Name", login.USR_FNAME + " " + login.USR_LNAME),
                        new Claim(JwtRegisteredClaimNames.Sub, login.USR_ID.ToString())
                    };

                    var keyBytes = Encoding.UTF8.GetBytes(Constants.Secret);

                    var key = new SymmetricSecurityKey(keyBytes);

                    var SigninCridentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        Constants.Audience,
                        Constants.Issuer,
                        claims,
                        notBefore: DateTime.Now,
                        expires: DateTime.Now.AddHours(1),
                        SigninCridentials);

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                    return new { accessToken = tokenString };
                }
            }
            return new { status_Msg = "EMAIL_OR_PASSWORD_INCORRECT"};
        }
    }
}
