using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlotChecker.src
{
    static class Tools
    {
        public static string GetMD5HashFromString(string TextToHash)
        {
            if ((TextToHash == null) || (TextToHash.Length == 0))
            {
                return string.Empty;
            }
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);
            return BitConverter.ToString(result);
        }
    }
}
