using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFullStack.Util.Helper
{
    public class BytesHelper
    {

        public static string HashString(string cleartext)
        {
            byte[] clearBytes = Encoding.UTF8.GetBytes(cleartext);
            return HashBytes(clearBytes);
        }

        public static byte[] StringToByte(string texto)
        {
            byte[] clearBytes = Encoding.UTF8.GetBytes(texto);
            SHA1 hasher = SHA1.Create();
            byte[] hashBytes = hasher.ComputeHash(clearBytes);
            hasher.Clear();
            return hashBytes;
        }

        public static string HashBytes(byte[] clearBytes)
        {
            SHA1 hasher = SHA1.Create();
            byte[] hashBytes = hasher.ComputeHash(clearBytes);
            string hash = System.Convert.ToBase64String(hashBytes);
            hasher.Clear();
            return hash;
        }
    }
}
