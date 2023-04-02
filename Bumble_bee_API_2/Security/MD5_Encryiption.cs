using System.Security.Cryptography;
using System.Text;

namespace Bumble_bee_API_2.Encryption
{
    public class MD5_Encryiption
    {
        public static byte[] Encrypt(string str)
        {
            MD5 md5 = MD5.Create();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str));
            byte[] result = md5.Hash;
            return result;
        }
    }
}
