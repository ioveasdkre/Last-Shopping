using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LastShopping.Services
{
    public class EncryptUtils
    {
        #region SHA256Encrypt [ SHA256加密 ]
        /// <summary>SHA256加密</summary>
        /// <param name="text">本文</param>
        /// <returns></returns>
        public static string SHA256Encrypt(string text)
        {
            // 判斷 字串為 null or ""
            if (string.IsNullOrEmpty(text))
                return string.Empty; // 空字串

            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hash = SHA256.Create().ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }
        #endregion
    }
}
