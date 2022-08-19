using Microsoft.Extensions.Configuration;

namespace LastShopping.Services
{
    #region AppSettingsUtils [ AppSettings工具 ]
    /// <summary>AppSettings工具</summary>
    public class AppSettingsUtils
    {
        #region [ 初始化 ]
        /// <summary>AppSettings DI注入</summary>
        private readonly IConfiguration _configruration;

        public AppSettingsUtils(IConfiguration configruration)
        {
            _configruration = configruration;
        }
        #endregion

        #region GetConnectionString [ 取AppSetting連線字串 ]
        /// <summary>取AppSetting連線字串</summary>
        /// <param name="ConnectionStringName">連線字串名稱</param>
        /// <returns>string 連線字串</returns>
        public static string GetConnectionString(string ConnectionStringName)
        {
            var builder = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json");
            var config = builder.Build();
            return config.GetConnectionString(ConnectionStringName);
        }
        #endregion

        #region GetAppSettingsValue [ 取AppSetting設定 ]
        /// <summary>
        /// 取AppSetting設定
        /// </summary>
        /// <param name="Key">主鍵</param>
        /// <param name="childKey">子鍵</param>
        /// <returns>string 值</returns>
        public static string GetAppSettingsValue(string Key, string childKey)
        {
            var builder = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json");
            var config = builder.Build();
            return config[$"{Key}:{childKey}"];
        }
        #endregion

        #region GetAppSetting [ DI注入取設定 取AppSetting設定 ]
        /// <summary>DI注入取設定 取AppSetting設定</summary>
        /// <param name="key">主鍵</param>
        /// <returns>string 值</returns>
        public string GetAppSetting(string key)
        {
            return _configruration[key];
        }
        #endregion
    }
    #endregion
}
