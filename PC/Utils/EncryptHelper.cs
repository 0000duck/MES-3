using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ChangKeTec.Wms.Utils
{
    public static class EncryptHelper
    {
        private const string EncryptKey = "CCCKKEJI";
        //定义密钥
        /// <summary>
        /// DEC 加密过程
        /// </summary>
        /// <param name="pToEncrypt">被加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string Encrypt(string pToEncrypt)
        {
            //访问数据加密标准(DES)算法的加密服务提供程序 (CSP) 版本的包装对象
            var des = new DESCryptoServiceProvider
            {
                Key = Encoding.ASCII.GetBytes(EncryptKey),
                IV = Encoding.ASCII.GetBytes(EncryptKey)
            };

            var inputByteArray = Encoding.Default.GetBytes(pToEncrypt);//把字符串放到byte数组中

            var ms = new MemoryStream();//创建其支持存储区为内存的流　
            //定义将数据流链接到加密转换的流
            var cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            //上面已经完成了把加密后的结果放到内存中去

            var ret = new StringBuilder();
            foreach (var b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();

        }

        /// <summary>
        /// DEC 解密过程
        /// </summary>
        /// <param name="pToDecrypt">被解密的字符串</param>
        /// <returns>返回被解密的字符串</returns>
        public static string Decrypt(string pToDecrypt)
        {
            var des = new DESCryptoServiceProvider();

            var inputByteArray = new byte[pToDecrypt.Length / 2];
            for (var x = 0; x < pToDecrypt.Length / 2; x++)
            {
                var i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }

            des.Key = Encoding.ASCII.GetBytes(EncryptKey);　//建立加密对象的密钥和偏移量，此值重要，不能修改
            des.IV = Encoding.ASCII.GetBytes(EncryptKey);
            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            return Encoding.Default.GetString(ms.ToArray());
        }


    }
}