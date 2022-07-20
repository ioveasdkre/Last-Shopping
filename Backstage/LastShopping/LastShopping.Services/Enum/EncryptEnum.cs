using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastShopping.Services.Enum
{
    public class EncryptEnum
    {
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
    }
}
