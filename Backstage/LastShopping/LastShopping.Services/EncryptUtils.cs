using System.Security.Cryptography;
using System.Text;
using static LastShopping.Services.Enum.EncryptEnum;

namespace LastShopping.Services
{
    /// <summary>加解密工具</summary>
    public class EncryptUtils
    {
        #region [ 初始化 ]
        /// <summary>加密</summary>
        private static byte[] Encrypt { get; set; } = null!;
        /// <summary>解密</summary>
        private static string Decrypt { get; set; } = string.Empty;
        public static readonly string AesKey = AppSettingsUtils.GetAppSettingsValue("AES", "Key");
        public static readonly string AesIv = AppSettingsUtils.GetAppSettingsValue("AES", "Iv");
        #endregion

        #region SHA256Encrypt [ SHA256雜湊加密 ]
        /// <summary>SHA256雜湊加密</summary>
        /// <param name="text">本文</param>
        /// <returns></returns>
        public static string SHA256Encrypt(string text, bool aesEncrypt = false, CiphertextType ciphertextType = CiphertextType.Base64)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text); // 轉換 UTF8編碼
            byte[] hash = SHA256.Create().ComputeHash(bytes); // SHA256 雜湊加密

            // 判斷使用 AES加密
            if (aesEncrypt)
            {
                return AESEncrypt(CipherByteArrayToString(hash, ciphertextType), AesKey, AesIv);
            }

;            return CipherByteArrayToString(hash, ciphertextType); // 8位元 轉 Base64字串
        }
        #endregion

        #region [ AES對稱加密 ]
        #region AESEncrypt [ AES對稱加密 ]
        /// <summary>AES對稱加密</summary>
        /// <param name="plainText">本文</param>
        /// <param name="key">密鑰</param>
        /// <param name="iv">初始向量</param>
        /// <param name="padding">填充模式</param>
        /// <param name="mode">加密模式</param>
        /// <param name="ciphertextType">密文類型</param>
        /// <returns>string 加密本文</returns>
        public static string AESEncrypt(string plainText, string key, string iv, PaddingMode padding = PaddingMode.PKCS7, CipherMode mode = CipherMode.CBC, CiphertextType ciphertextType = CiphertextType.Base64)
        {
            using (Aes aesAlg = Aes.Create()) // 建立 Aes對稱演算法的密碼編譯物件
            {
                // Base64: 128 = 16 bytes, 192 = 24 bytes, 256 = 32 bytes
                // HEX: 128 = 32 (0-9 A-F), 192 = 48 (0-9 A-F), 256 = 64 (0-9 A-F)
                aesAlg.KeySize = 256; // 對稱演算法使用之秘密金鑰的大小，以位元為單位
                aesAlg.BlockSize = 128; // 密碼編譯作業的區塊大小，以位元為單位
                aesAlg.Padding = padding; // 對稱演算法中使用的填補模式,預設 PKCS7
                aesAlg.Mode = mode; // 對稱演算法的作業模式,預設 CBC

                // SHA256 32位元
                // MD5 16位元
                aesAlg.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(key)); // 對稱演算法的秘密金鑰

                byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
                byte[] useIvBytes = new byte[16]; // 儲存 16byte的籃子 若超過加密會失敗

                // 判斷 加密長度大於 設定的長度
                if (ivBytes.Length > useIvBytes.Length)
                {
                    // Array.Copy(目標, 資料來源, 長度)
                    Array.Copy(ivBytes, useIvBytes, useIvBytes.Length);
                }
                else
                {
                    // Array.Copy(目標, 資料來源, 長度)
                    Array.Copy(ivBytes, useIvBytes, ivBytes.Length);
                }

                aesAlg.IV = useIvBytes; // 對稱演算法的初始化向量，如果沒有設置默認的16個0

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(); // 建立對稱 AES加密子物件

                using (MemoryStream msEncrypt = new()) // 存放區為記憶體的資料流
                {
                    using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write)) // 定義連結資料流與密碼編譯轉換的資料流
                    {
                        using (StreamWriter swEncrypt = new(csEncrypt)) // 實作以特定的編碼方式將字元寫入位元組資料流的 TextWriter
                        {
                            swEncrypt.Write(plainText); // 寫入資料至資料流。
                        }

                        Encrypt = msEncrypt.ToArray(); // 將資料流內容寫入陣列
                    }
                }
            }

            return CipherByteArrayToString(Encrypt, ciphertextType);
        }
        #endregion

        #region AESDecrypt [ AES對稱解密 ]
        /// <summary>AES解密</summary>
        /// <param name="cipherText">本文</param>
        /// <param name="key">密鑰</param>
        /// <param name="iv">初始向量</param>
        /// <param name="padding">填充模式</param>
        /// <param name="mode">加密模式</param>
        /// <param name="ciphertextType">密文類型</param>
        /// <returns>string 解密本文</returns>
        public static string AESDecrypt(string cipherText, string key, string iv = "", PaddingMode padding = PaddingMode.PKCS7, CipherMode mode = CipherMode.CBC, CiphertextType ciphertextType = CiphertextType.Base64)
        {
            using (Aes aesAlg = Aes.Create()) // 建立 Aes對稱演算法的密碼編譯物件
            {
                byte[] cipherByte = CiphertextStringToByteArray(cipherText, ciphertextType);

                aesAlg.KeySize = 256;//秘钥的大小，以位为单位,128,256等
                aesAlg.BlockSize = 128;//支持的块大小
                aesAlg.Padding = padding;//填充模式
                aesAlg.Mode = mode;
                // SHA256 32位元
                // MD5 16位元
                aesAlg.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(key)); // 對稱演算法的秘密金鑰

                byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
                byte[] useIvBytes = new byte[16]; // 儲存 16byte的籃子 若超過加密會失敗

                // 判斷 加密長度大於 設定的長度
                if (ivBytes.Length > useIvBytes.Length)
                {
                    // Array.Copy(目標, 資料來源, 長度)
                    Array.Copy(ivBytes, useIvBytes, useIvBytes.Length);
                }
                else
                {
                    // Array.Copy(目標, 資料來源, 長度)
                    Array.Copy(ivBytes, useIvBytes, ivBytes.Length);
                }

                aesAlg.IV = useIvBytes; // 對稱演算法的初始化向量，如果沒有設置默認的16個0

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(); //建立對稱 AES解密子物件

                using (MemoryStream msDecrypt = new(cipherByte)) // 存放區為記憶體的資料流
                {
                    using (CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read)) // 實作以特定的編碼方式將字元寫入位元組資料流的 TextWriter
                    {
                        using (StreamReader srDecrypt = new(csDecrypt)) // 實作以特定的編碼方式將字元寫入位元組資料流的 TextWriter
                        {
                            Decrypt = srDecrypt.ReadToEnd(); // 從解密流中讀取解密的字節並將它們放在一個字符串中。
                        }
                    }
                }
            }
            return Decrypt;
        }
        #endregion
        #endregion

        #region CipherByteArrayToString [ 通過加密的 Byte數組返回加密後的密文 ]
        /// <summary>通過加密的 Byte數組返回加密後的密文</summary>
        /// <param name="cipherByte">加密位元</param>
        /// <param name="ciphertextType">加密類型</param>
        /// <returns>string 加密資料</returns>
        public static string CipherByteArrayToString(byte[] cipherByte, CiphertextType ciphertextType)
        {
            string ciphertext = ""; // 儲存密鑰

            switch (ciphertextType) // 判斷加密類型
            {
                case CiphertextType.Base64:
                    ciphertext = Convert.ToBase64String(cipherByte); // 8位元 轉 Base64String
                    break;
                case CiphertextType.Hex:
                    ciphertext = ByteArrayToHexString(cipherByte); // 8位元 轉 HexString
                    break;
                default:
                    ciphertext = Convert.ToBase64String(cipherByte); // 8位元 轉 Base64String
                    break;
            }
            return ciphertext;
        }
        #endregion

        #region ByteArrayToHexString [ Byte转Hex字符串 ]
        /// <summary>
        /// 8位元 轉 HexString
        /// </summary>
        /// <param name="data">加密 Byte數組</param>
        /// <returns>HexString</returns>
        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new(data.Length * 3); // 字串長度初始化
            foreach (byte b in data)
            {
                // 將 b轉換成 16Byte的字串, 並設定總長度為2, 若未達總長度則補上指定字元, 最後加入至 sb
                // PadLeft(長度, 填補字元) 傳回新字串，此字串會以指定的 Unicode 字元填補左側至指定的總長度，靠右對齊這個執行個體中的字元
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            }
            return sb.ToString().ToUpper(); // 轉 string並 英文轉大寫
        }
        #endregion

        #region CiphertextStringToByteArray [ 通過密文返回加密 Byte數組 ]
        /// <summary>通過密文返回加密 Byte數組</summary>
        /// <param name="ciphertext">加密字串</param>
        /// <param name="ciphertextType">加密類型</param>
        /// <returns>Byte[] 加密</returns>
        public static byte[] CiphertextStringToByteArray(string ciphertext, CiphertextType ciphertextType)
        {
            byte[] cipherByte;
            switch (ciphertextType)
            {
                case CiphertextType.Base64:
                    cipherByte = Convert.FromBase64String(ciphertext); // Base64String 轉 8位元
                    break;
                case CiphertextType.Hex:
                    cipherByte = HexStringToByteArray(ciphertext); // Base64String 轉 HexString
                    break;
                default:
                    cipherByte = Convert.FromBase64String(ciphertext); // Base64String 轉 8位元
                    break;
            }
            return cipherByte;
        }
        #endregion

        #region HexStringToByteArray [ Base64String 轉 HexString ]
        /// <summary>Base64String 轉 HexString</summary>
        /// <param name="hexContent">hex加密字串</param>
        /// <returns>Byte[] 加密</returns>
        public static byte[] HexStringToByteArray(string hexContent)
        {
            hexContent = hexContent.Replace(" ", ""); // Replace(取代來源, 取代目標)
            byte[] buffer = new byte[hexContent.Length / 2];
            for (int i = 0; i < hexContent.Length; i += 2)
            {
                // Substring(字元位置, 讀取幾個字元) 指定 字元位置 讀取指定 數位個字元
                buffer[i / 2] = Convert.ToByte(hexContent.Substring(i, 2), 16); // 轉換成 8位元
            }
            return buffer;
        }
        #endregion
    }
}
