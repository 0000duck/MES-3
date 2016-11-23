using System;
using System.IO;
using System.Reflection;

namespace ChangKeTec.Wms.Utils
{
    public static class IoHelper
    {
        public static string GetDllPath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public static string GetFullPath(string rootPath, string path)
        {
            if (!Directory.Exists(rootPath))
                Directory.CreateDirectory(rootPath);
            if (!rootPath.EndsWith("\\"))
                rootPath += "\\";
            var fullPath = rootPath + path;
            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);
            return rootPath + path;
        }

        public static string GetFullFilename(string path, string filename, bool isLocal = true)
        {
            var str = string.Empty;
            if (isLocal) str += GetDllPath() + "\\";
            str += GetPath(path) + "\\" + filename;
            return str;
        }

        public static string GetPath(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        public static System.Text.Encoding GetFileEncodeType(string filename)
        {
            System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open,
                System.IO.FileAccess.Read);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
            Byte[] buffer = br.ReadBytes(2);
            if (buffer[0] >= 0xEF)
            {
                if (buffer[0] == 0xEF && buffer[1] == 0xBB)
                {
                    return System.Text.Encoding.UTF8;
                }
                else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                {
                    return System.Text.Encoding.BigEndianUnicode;
                }
                else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                {
                    return System.Text.Encoding.Unicode;
                }
                else
                {
                    return System.Text.Encoding.Default;
                }
            }
            else
            {
                return System.Text.Encoding.Default;
            }
        }

     
    }
}
