using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LastShopping.Services.Enums
{
    /// <summary>加密列舉</summary>
    public class EnumEncrypt
    {
        #region CiphertextType [ 加密類型 ]
        /// <summary>加密類型</summary>
        public enum CiphertextType
        {
            /// <summary>Base64</summary>
            [Description("Base64")]
            Base64,
            /// <summary>16進制字符串</summary>
            [Description("16進制字符串")]
            Hex
        }
        #endregion
    }
}
