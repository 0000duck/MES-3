using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.ErpInterface
{
    public static class GlobalVar
    {
        public const string WmsServer = "WmsDbServer";
        public const string WmsPort = "WmsDbPort";
        public const string WmsDb = "WmsDbName";
        public const string WmsUser = "WmsDbUser";
        public const string WmsPassword = "WmsDbPassword";

        public const string JisServer = "JisDbServer";
        public const string JisPort = "JisDbPort";
        public const string JisDb = "JisDbName";
        public const string JisUser = "JisDbUser";
        public const string JisPassword = "JisDbPassword";

        public const string MesServer = "MesDbServer";
        public const string MesPort = "MesDbPort";
        public const string MesDb = "MesDbName";
        public const string MesUser = "MesDbUser";
        public const string MesPassword = "MesDbPassword";

        public const string LocalRoot = "LocalRoot";
        public const string PathFromErp = "PathFromErp";
        public const string PathToErp = "PathToErp";
        public const string PathBak = "PathBak";

        public const string FtpServer = "FtpServer";
        public const string FtpPort = "FtpPort";
        public const string FtpUser = "FtpUser";
        public const string FtpPassword = "FtpPassword";
        public const string FtpRootPath = "FtpRootPath";
        public const string FtpFromErp = "FtpFromErp";
        public const string FtpToErp = "FtpToErp";

        public const string JisSortPath = "JisSortPath";
        public const string JisSortPathBak = "JisSortPathBak";

        public const string ErpPutDuration = "ErpPutDuration";
        public const string ErpGetDuration = "ErpGetDuration";
        public const string MesGetDuration = "MesGetDuration";
        public const string VinExeDuration = "VinExeDuration";
        public const string JisSortDuration = "JisSortDuration";
        public const string JisPartDuration = "JisPartDuration";

        public static  string MesUserName = "MesUser";
        public static  string JisUserName = "JisUser";
        public static  string IsFtp = "true";

        static GlobalVar()
        {
           Init();
        }

        public static bool EnableNegativeStock { get; set; }
        public static string OperName { get; set; }

        private static void Init()
        {
            OperName = "system";
            MesUserName = AppConfigHelper.GetAppValue("MesUserName");
            JisUserName = AppConfigHelper.GetAppValue("JisUserName");
            IsFtp = AppConfigHelper.GetAppValue("IsFtp");
            EnableNegativeStock = false;
        }
    }
}