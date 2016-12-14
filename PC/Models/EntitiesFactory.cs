using System;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.Models
{
    public static class EntitiesFactory
    {
//        private static JisEntities _readOnlyJisDb;
//        private static MesEntities _readOnlyMesDb;
//        private static SpareEntities _readOnlyWmsDb;


/*
        public static MesEntities CreateMesInstance()
        {
            return new MesEntities(GetEfConnctionString("Mes"));
        }
*/

        public static SpareEntities CreateSpareInstance()
        {
            return new SpareEntities(GetEfConnctionString("Spare"));
        }

        public static InterfaceEntities CreateInterfaceInstance()
        {
            return new InterfaceEntities(GetEfConnctionString("Interface"));
        }

        public static PowerEntities CreatePowerInstance()
        {
            return new PowerEntities(GetEfConnctionString("Power"));
        }

        //        public static WMSDBEntities GetReadOnlyInstance()
        //        {
        //            return _readOnlyJisDb ?? (_readOnlyJisDb = new WMSDBEntities(GetEfConnctionString()));
        //        }

        public static string WmsConnectionString;

        //使用自定义连接串
        private static string GetEfConnctionString(string dbType)
        {
            DbInfo dbInfo = new DbInfo(dbType);

            var modelName = dbInfo.ModelName;
            var ecb = new EntityConnectionStringBuilder
            {
                Metadata = "res://*/" + modelName + ".csdl|res://*/" + modelName + ".ssdl|res://*/" + modelName + ".msl",

            };
            var sbConn = new StringBuilder();

            switch (dbType)
            {
                case "Wms":
                case "Mes":
                case "Power":
                case "Scp":
                case "Spare":
                case "Interface":
                    sbConn.Append("Data source =" + AppConfigHelper.GetAppValue(dbInfo.DbServer) + "," + AppConfigHelper.GetAppValue(dbInfo.DbPort) + ";");
                    sbConn.Append("Initial catalog = " + AppConfigHelper.GetAppValue(dbInfo.DbName) + ";");
                    sbConn.Append("User id = " + AppConfigHelper.GetAppValue(dbInfo.DbUser) + ";");
                    sbConn.Append("Password = " + EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(dbInfo.DbPassword)) +";");
                    sbConn.Append("MultipleActiveResultSets = True;");
                    sbConn.Append("persist security info = True;");

                    WmsConnectionString = "Provider=SQLOLEDB.1;"+sbConn.ToString();

                    sbConn.Append("App = EntityFramework;");

                    ecb.Provider = "System.Data.SqlClient";


                    break;
                case "Jis":
                    //metadata=res://*/ModelJis.csdl|res://*/ModelJis.ssdl|res://*/ModelJis.msl;
                    //provider =MySql.Data.MySqlClient;
                    //provider connection string=&quot;
                    //server =10.233.8.60;
                    //user id=root;
                    //password =root;
                    //database =edinew;
                    //persistsecurityinfo =True&quot;" providerName="System.Data.EntityClient
                    sbConn.Append("server =" + AppConfigHelper.GetAppValue(dbInfo.DbServer) + ";");
                    sbConn.Append("port =" + AppConfigHelper.GetAppValue(dbInfo.DbPort) + ";");
                    sbConn.Append("database = " + AppConfigHelper.GetAppValue(dbInfo.DbName) + ";");
                    sbConn.Append("user id = " + AppConfigHelper.GetAppValue(dbInfo.DbUser) + ";");
                    sbConn.Append("password = " + EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(dbInfo.DbPassword)) +
                                  ";");
                    sbConn.Append("persistsecurityinfo =True;");
                    ecb.Provider = "MySql.Data.MySqlClient";
                    break;
            }
            ecb.ProviderConnectionString = sbConn.ToString();
            return ecb.ConnectionString;
        }


//        public static void SaveDb(MesEntities db)
//        {
//            db.SaveChanges();
//        }

        public static async Task SaveDbAsync(DbContext db)
        {
            try
            {
                await db.SaveChangesAsync();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)//捕获实体验证异常
            {
                var sb = new StringBuilder();

                foreach (var error in dbEx.EntityValidationErrors.ToList())
                {

                    error.ValidationErrors.ToList().ForEach(i =>
                    {
                        sb.AppendFormat("表：{0}，字段：{1}，信息：{2}\r\n", error.Entry.Entity.GetType().Name, i.PropertyName, i.ErrorMessage);
                    });
                }
                throw new WmsException(ResultCode.DbEntityValidationException, sb.ToString());
            }
            catch (OptimisticConcurrencyException ex)//并发冲突异常
            {
                Console.WriteLine(ex.ToString());
                throw new WmsException(ResultCode.Exception, "9999", ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                UpdateException inner = (UpdateException)ex.InnerException;

                Console.WriteLine(inner?.StateEntries[0].EntitySet.Name);
                throw new WmsException(ResultCode.Exception, "0000", ex.ToString());

            }
        }

        public static  void SaveDb(DbContext db)
        {
            try
            {
                 db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)//捕获实体验证异常
            {
                var sb = new StringBuilder();

                foreach (var error in dbEx.EntityValidationErrors.ToList())
                {
                   
                    error.ValidationErrors.ToList().ForEach(i =>
                    {
                        sb.AppendFormat("表：{0}，字段：{1}，信息：{2}\r\n", error.Entry.Entity.GetType().Name, i.PropertyName, i.ErrorMessage);
                    });
                }
                throw new WmsException(ResultCode.DbEntityValidationException, sb.ToString());
            }
            catch (OptimisticConcurrencyException ex)//并发冲突异常
            {
                Console.WriteLine(ex.ToString());
                throw new WmsException(ResultCode.Exception,"9999", ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                UpdateException inner = (UpdateException) ex.InnerException;

                Console.WriteLine(inner?.StateEntries[0].EntitySet.Name);
                throw new WmsException(ResultCode.Exception, "0000", ex.ToString());

            }
        }


        private class DbInfo
        {
            private string modelName = "Model";
            private string dbServer = "DbServer";
            private string dbPort = "DbPort";
            private string dbName = "DbName";
            private string dbUser = "DbUser";
            private string dbPassword = "DbPassword";

            public DbInfo(string db)
            {
                ModelName = modelName + db;
                DbServer = db + dbServer;
                DbPort = db + dbPort;
                DbName = db + dbName;
                DbUser = db + dbUser;
                DbPassword = db + dbPassword;
            }

            public string ModelName { get; }
            public string DbServer { get; }
            public string DbPort { get; }
            public string DbName { get; }
            public string DbUser { get; }
            public string DbPassword { get; }
        }

      

    }
}