using System.Security.Cryptography;
using System.Text;

namespace Login
{
    internal class HashCode
    {
        public string PassHash(string data)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < hashData.Length; i++)
            {
                sb.Append(hashData[i]);
            }
            return sb.ToString();
        }
    }
}
