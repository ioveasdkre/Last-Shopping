using System.Security.Cryptography;
using System.Text;
using static LastShopping.Services.Enum.EncryptEnum;

namespace LastShopping.Services
{
    public class EncryptUtils
    {
        private static byte[] Encrypt { get; set; }

        #region SHA256Encrypt [ SHA256雜湊加密 ]
        /// <summary>SHA256雜湊加密</summary>
        /// <param name="text">本文</param>
        /// <returns></returns>
        public static (bool isSuccess, string text) SHA256Encrypt(string text)
        {
            try
            {
                // 判斷 字串為 null or ""
                if (string.IsNullOrEmpty(text))
                    return (false, ""); // 空字串

                byte[] bytes = Encoding.UTF8.GetBytes(text); // 轉換 UTF8編碼
                byte[] hash = SHA256.Create().ComputeHash(bytes); // SHA256 雜湊加密

                return (true, Convert.ToBase64String(hash)); // 轉 Base-64
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        #endregion

        #region AESEncrypt [ AES加密 ]
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="plainText">資料文字</param>
        /// <param name="key">key</param>
        /// <param name="iv">iv</param>
        /// <returns>加密後文字</returns>
        /// <exception cref="Exception"></exception>
        public static (bool isSuccess, string text) AESEncrypt(string plainText, string key, string iv, PaddingMode padding = PaddingMode.PKCS7, CipherMode mode = CipherMode.CBC, CiphertextType ciphertextType = CiphertextType.Base64)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.KeySize = 256; // 對稱演算法使用之秘密金鑰的大小，以位元為單位
                    aesAlg.BlockSize = 128; // 密碼編譯作業的區塊大小，以位元為單位
                    aesAlg.Padding = padding; // 對稱演算法中使用的填補模式
                    aesAlg.Mode = mode; // 對稱演算法的作業模式

                    // SHA256 32位元
                    // MD5 16位元
                    aesAlg.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(key)); // 對稱演算法的秘密金鑰
                    aesAlg.IV = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(iv)); // 對稱演算法的初始化向量，如果沒有設置默認的16個0

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor();

                    using (MemoryStream msEncrypt = new())
                    {
                        using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new(csEncrypt))
                            {
                                swEncrypt.Write(plainText); // 將所有數據寫入流。
                            }

                            Encrypt = msEncrypt.ToArray();
                        }
                    }
                    return (true, CipherByteArrayToString(Encrypt, ciphertextType));
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        #endregion

        public static string CipherByteArrayToString(byte[] cipherByte, CiphertextType ciphertextType)
        {
            string ciphertext = "";
            switch (ciphertextType)
            {
                case CiphertextType.Base64:
                    ciphertext = Convert.ToBase64String(cipherByte);
                    break;
                case CiphertextType.Hex:
                    ciphertext = ByteArrayToHexString(cipherByte);
                    break;
                default:
                    ciphertext = Convert.ToBase64String(cipherByte);
                    break;
            }
            return ciphertext;
        }

        /// <summary>
        /// Byte转Hex字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            }
            return sb.ToString().ToUpper();
        }
    }
}
