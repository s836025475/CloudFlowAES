using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CloudFlowAES
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "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";
            //string base64Str = Decrypt(str);
            string decrypt = AesDecrypt(str, "T22cdkEko3flglPe");
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string AesDecrypt(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = Convert.FromBase64String(str);

            RijndaelManaged rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rm.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }
    }
}
