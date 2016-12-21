using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Util;

namespace ChangKeTec.Wms.WinForm.Update
{
    public static class UpdateControl
    {
        public static void GetLocalFilesInfo(Updates localFiles, DirectoryInfo di)
        {
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo fi in fis)
            {
                if (".PDB .XML".Contains(fi.Extension.ToUpper()))
                    continue;

                UpdateItem item = new UpdateItem();
                item.FullName = fi.FullName;
                item.FileName = GetRelativePath(Application.StartupPath, fi.FullName);
                item.FileSize = fi.Length;
                item.ModifyDate = fi.LastWriteTime;
                localFiles.Add(item);
            }
            DirectoryInfo[] dis = di.GetDirectories();
            foreach (DirectoryInfo dinfo in dis)
            {
                GetLocalFilesInfo(localFiles, dinfo);
            }
        }

        public static Updates GetServerFilesInfo()
        {
            return (Updates)LoadObj("Updates", "Updates", null);
        }

        /// <summary>
        /// 获取路径2相对于路径1的相对路径
        /// </summary>
        /// <param name="strPath1">路径1</param>
        /// <param name="strPath2">路径2</param>
        /// <returns>返回路径2相对于路径1的路径</returns>
        /// <example>
        /// string strPath = GetRelativePath(@"C:/WINDOWS/system32", @"C:/WINDOWS/system/*.*" );
        /// //strPath == @"../system/*.*"
        /// </example>
        public static string GetRelativePath(string strPath1, string strPath2)
        {
            if (!strPath1.EndsWith("\\")) strPath1 += "\\";    //如果不是以"/"结尾的加上"/"
            int intIndex = -1, intPos = strPath1.IndexOf("\\");
            ///以"/"为分界比较从开始处到第一个"/"处对两个地址进行比较,如果相同则扩展到
            ///下一个"/"处;直到比较出不同或第一个地址的结尾.
            while (intPos >= 0)
            {
                intPos++;
                if (string.Compare(strPath1, 0, strPath2, 0, intPos, true) != 0) break;
                intIndex = intPos;
                intPos = strPath1.IndexOf("\\", intPos);
            }

            ///如果从不是第一个"/"处开始有不同,则从最后一个发现有不同的"/"处开始将strPath2
            ///的后面部分付值给自己,在strPath1的同一个位置开始望后计算每有一个"/"则在strPath2
            ///的前面加上一个"../"(经过转义后就是"..//").
            if (intIndex >= 0)
            {
                strPath2 = strPath2.Substring(intIndex);
                intPos = strPath1.IndexOf("\\", intIndex);
                while (intPos >= 0)
                {
                    strPath2 = "..\\" + strPath2;
                    intPos = strPath1.IndexOf("\\", intPos + 1);
                }
            }
            //否则直接返回strPath2
            return strPath2;
        }

        public static object LoadObj(string type, string name, object defobj) //从系统表中得到对象
        {
            Object aObject;
            SpareEntities db = EntitiesFactory.CreateSpareInstance();
            var obj = db.TS_CONFIG.FirstOrDefault(p => p.GRPID == type.Trim() && p.KEYID == name.Trim());
            if (obj == null)
            {
                return defobj;
            }
            try
            {
                byte[] blobdata = (byte[])(obj.DATA);
                if (blobdata.Length == 0)
                {
                    return null;
                }

                Stream stream = new MemoryStream();
                stream.Write(blobdata, 0, blobdata.Length);
                stream.Position = 0;
                IFormatter formatter = new BinaryFormatter();

                aObject = formatter.Deserialize(stream);
                stream.Close();
            }
            catch
            {
                aObject = defobj;
            }
            return aObject;
        }

        public static void SaveFile2DB(SpareEntities db,string type, string name, FileStream fs)
        {
            fs.Position = 0;
            byte[] blobdata = new Byte[fs.Length];
            fs.Read(blobdata, 0, (int)fs.Length);
            fs.Close();
            var obj = db.TS_CONFIG.FirstOrDefault(p => p.GRPID == type.Trim() && p.KEYID == name.Trim());
            if (obj == null)
            {
                obj = new TS_CONFIG()
                {
                    GRPID = type.Trim(),
                    KEYID = name.Trim(),
                    DATA = blobdata
                };
            }
            db.TS_CONFIG.AddOrUpdate(obj);   
        }

        public static void SaveObj(SpareEntities db,string type, string name, object obj) //将对象存入系统表
        {
            //将对象流化到流
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            formatter.Serialize(stream, obj);
            stream.Position = 0;
            // Read  into a byte array
            byte[] blobdata = new Byte[stream.Length];
            stream.Read(blobdata, 0, (int)stream.Length);
            stream.Close();
            var config = db.TS_CONFIG.FirstOrDefault(p => p.GRPID == type.Trim() && p.KEYID == name.Trim());
            if (config == null)
            {
                config = new TS_CONFIG()
                {
                    GRPID = type.Trim(),
                    KEYID = name.Trim(),
                    DATA = blobdata
                };
            }
            db.TS_CONFIG.AddOrUpdate(config);
        }

        public static bool DownloadServerFiles()
        {
            //同步服务器时间
            SpareEntities db = EntitiesFactory.CreateSpareInstance();
            DateTime dtNow = db.Database.SqlQuery<DateTime>("select getdate()").FirstOrDefault();
            if (dtNow != null)
            {
                TimeHelper.SyncTime(DateTime.Parse(dtNow.ToString()));
            }

            bool bReturn = false;
            int iFind = -1;
            Updates servers = GetServerFilesInfo();
            if (servers == null)
            {
                return bReturn;
            }
            Updates locals = new Updates();
            GetLocalFilesInfo(locals, new System.IO.DirectoryInfo(Application.StartupPath));
            string sFullname = "";
            string sPath = "";

            foreach (UpdateItem item in servers)
            {
                iFind = locals.Find(item.FileName);
                if (iFind >= 0)
                {
                    if (item.ModifyDate > locals[iFind].ModifyDate.AddSeconds(5))
                    {                          
                        Application.DoEvents();
                        sFullname = Application.StartupPath + @"\updatetmp\" + item.FileName;
                        sPath = Path.GetDirectoryName(sFullname);
                        if (!Directory.Exists(sPath))
                            Directory.CreateDirectory(sPath);
                        FileStream tmpfs = (FileStream)LoadFileFromDB(db,"BLMUpdate", item.FileName, sFullname);
                        tmpfs.Close();
                        bReturn = true;
                    }
                }
                else
                {
                    Application.DoEvents();
                    sFullname = Application.StartupPath + @"\updatetmp\" + item.FileName;
                    sPath = Path.GetDirectoryName(sFullname);
                    if (!Directory.Exists(sPath))
                        Directory.CreateDirectory(sPath);
                    FileStream tmpfs = (FileStream)LoadFileFromDB(db,"BLMUpdate", item.FileName, sFullname);
                    tmpfs.Close();
                    bReturn = true;
                }
            }
            return bReturn;
        }

        public static FileStream LoadFileFromDB(SpareEntities db,string type, string name, string sPathName)
        {
            Object aObject;
            var obj = db.TS_CONFIG.FirstOrDefault(p => p.GRPID == type.Trim() && p.KEYID == name.Trim());
            if (obj == null)
            {
                return null;
            }
            else
            {
                byte[] blobdata = (byte[])(obj.DATA);
                if (blobdata.Length == 0)
                {
                    return null;
                }

                FileStream fs = new FileStream(sPathName, FileMode.OpenOrCreate);
                fs.Write(blobdata, 0, blobdata.Length);
                fs.Position = 0;
                fs.Close();
                return fs;
            }
        }

        public static void KillSelfThenRun()
        {
            string tempUpdatePath = Application.StartupPath + @"\updatetmp\";
            string strXCopyFiles = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XCopyFiles.bat");
            StreamWriter swXcopy = new StreamWriter(strXCopyFiles, false, Encoding.GetEncoding("gb2312"));
            {
                string strOriginalPath = tempUpdatePath.Substring(0, tempUpdatePath.Length - 1);
                swXcopy.WriteLine(string.Format(@"
                                                @echo off
                                                xcopy /y/s/e/v """ + strOriginalPath + @""" """ + Directory.GetCurrentDirectory() + @"""", AppDomain.CurrentDomain.FriendlyName));
                swXcopy.Flush();
                swXcopy.Close();
            }
            string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "killmyself.bat");
            StreamWriter swBat = new StreamWriter(filename, false, Encoding.GetEncoding("gb2312"));
            {
                //find main app exe file
                if (!File.Exists(tempUpdatePath + AppDomain.CurrentDomain.FriendlyName))
                    swBat.WriteLine(string.Format(@"     
                        @echo off
                        call XCopyFiles.bat
                        del XCopyFiles.bat
                         rd /s /q """ + tempUpdatePath + @"""" + Environment.NewLine +
                        @"start " + Path.GetFileName(Application.ExecutablePath) + @" -d """ + Application.ExecutablePath + @"""" + Environment.NewLine +
                        @"del %0 ", AppDomain.CurrentDomain.FriendlyName));
                else
                    // 自删除,自啟動
                    swBat.WriteLine(string.Format(@"
                        @echo off
                        :selfkill
                        attrib -a -r -s -h ""{0}""
                        del ""{0}""
                        if exist ""{0}"" goto selfkill
                        call XCopyFiles.bat
                        del XCopyFiles.bat
                         rd /s /q """ + tempUpdatePath + @"""" + Environment.NewLine +
                        @"start " + Path.GetFileName(Application.ExecutablePath) + @" -d """ + Application.ExecutablePath + @"""" + Environment.NewLine +
                        @"del %0 ", AppDomain.CurrentDomain.FriendlyName));
                swBat.Flush();
                swBat.Close();
            }

            // 启动自删除批处理文件
            ProcessStartInfo info = new ProcessStartInfo(filename);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(info);

            // 强制关闭当前进程
            //Environment.Exit(0);
            Application.Exit();
        }
    }
}
