using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace LastShopping.Services
{
    public class EnumUtils
    {
        #region GetDescription [ 加密類型 ]
        /// <summary>取列舉描述</summary>
        /// <param name="enumValue">列舉</param>
        /// <returns>列舉描述</returns>
        public static string GetDescription(Enum enumValue)
        {
            return enumValue.GetType()
                       .GetMember(enumValue.ToString())
                       .First()
                       .GetCustomAttribute<DescriptionAttribute>()?
                       .Description ?? string.Empty;
        }
        #endregion
    }
}
