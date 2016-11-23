using System.Configuration;
using System.Linq;

namespace ChangKeTec.Wms.Utils
{
    public static class AppConfigHelper
    {
      

        /// <summary>
        ///     获取AppSettings配置节中的Key值
        /// </summary>
        /// <param name="keyName">Key's name</param>
        /// <returns>Key's value</returns>
        public static string GetAppValue(string keyName)
        {
            return ConfigurationManager.AppSettings.Get(keyName);
        } /**/

        /// <summary>
        ///     获取ConnectionStrings配置节中的值
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            var settings = ConfigurationManager.ConnectionStrings["ConnString"];
            return settings.ConnectionString;
        } /**/

        /// <summary>
        ///     保存节点中ConnectionStrings的子节点配置项的值
        /// </summary>
        /// <param name="strConn"></param>
        public static void SetConnectionString(string strConn)
        {
            var config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["ConnString"].ConnectionString = strConn;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

        } /**/

        /// <summary>
        ///     判断appSettings中是否有此项
        /// </summary>
        private static bool IsAppKeyExists(string strKey, Configuration config)
        {
            return config.AppSettings.Settings.AllKeys.Any(str => str == strKey);
        } /**/

        /// <summary>
        ///     保存appSettings中某key的value值
        /// </summary>
        /// <param name="strKey">key's name</param>
        /// <param name="newValue">value</param>
        public static void SetAppValue(string strKey, string newValue)
        {
            var config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!IsAppKeyExists(strKey, config)) return;
            config.AppSettings.Settings[strKey].Value = newValue;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }


    }
}