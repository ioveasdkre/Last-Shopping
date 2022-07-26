using System.ComponentModel.DataAnnotations;

namespace LastShopping.Services.Enum
{
    /// <summary>加密列舉</summary>
    public class EncryptEnum
    {
        #region CiphertextType [ 加密類型 ]
        /// <summary>加密類型</summary>
        public enum CiphertextType
        {
            /// <summary>Base64</summary>
            [Display(Name = "Base64")]
            Base64 = 0,
            /// <summary>16進制字符串</summary>
            [Display(Name = "16進制字符串")]
            Hex = 1
        }
        #endregion
    }
}
