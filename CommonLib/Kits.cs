using System.Security.Cryptography;
using System.Text;

namespace CommonLib
{
    public class Kits
    {
        /// <summary>
        /// /MD5加密
        /// </summary>
        /// <param name="sourceStr">需要加密的字符串</param>
        /// <returns></returns>
        public static string GetMD5(string sourceStr)
        {
            StringBuilder sb = new StringBuilder();
            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(sourceStr));

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
            }
            return sb.ToString().Replace("-", "");
        }
       
    }
}