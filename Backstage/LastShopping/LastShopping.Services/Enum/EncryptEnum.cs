using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastShopping.Services.Enum
{
    public class EncryptEnum
    {
        public enum CiphertextType
        {
            /// <summary>
            /// Base64
            /// </summary>
            Base64 = 1,
            /// <summary>
            /// 16进制字符串
            /// </summary>
            Hex = 2
        }

    }
}
