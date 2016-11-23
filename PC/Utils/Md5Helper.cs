using System;
using System.Collections;
using System.IO;

namespace ChangKeTec.Wms.Utils
{
    public class Md5Helper
    {
        private const int S11 = 7;

        private const int S12 = 12;

        private const int S13 = 17;

        private const int S14 = 22;

        private const int S21 = 5;

        private const int S22 = 9;

        private const int S23 = 14;

        private const int S24 = 20;

        private const int S31 = 4;

        private const int S32 = 11;

        private const int S33 = 16;

        private const int S34 = 23;

        private const int S41 = 6;

        private const int S42 = 10;

        private const int S43 = 15;

        private const int S44 = 21;

        private static uint A;

        private static uint B;

        private static uint C;

        private static uint D;

        private static uint F(uint x, uint y, uint z)
        {
            return (x & y) | (~x & z);
        }

        private static uint G(uint x, uint y, uint z)
        {
            return (x & z) | (y & ~z);
        }

        private static uint H(uint x, uint y, uint z)
        {
            return x ^ y ^ z;
        }

        private static uint I(uint x, uint y, uint z)
        {
            return y ^ (x | ~z);
        }

        private static void FF(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
        {
            a = a + Md5Helper.F(b, c, d) + mj + ti;
            a = (a << s | a >> 32 - s);
            a += b;
        }

        private static void GG(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
        {
            a = a + Md5Helper.G(b, c, d) + mj + ti;
            a = (a << s | a >> 32 - s);
            a += b;
        }

        private static void HH(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
        {
            a = a + Md5Helper.H(b, c, d) + mj + ti;
            a = (a << s | a >> 32 - s);
            a += b;
        }

        private static void II(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
        {
            a = a + Md5Helper.I(b, c, d) + mj + ti;
            a = (a << s | a >> 32 - s);
            a += b;
        }

        private static void MD5_Init()
        {
            Md5Helper.A = 1732584193u;
            Md5Helper.B = 4023233417u;
            Md5Helper.C = 2562383102u;
            Md5Helper.D = 271733878u;
        }

        private static uint[] MD5_Append(byte[] input)
        {
            int ones = 1;
            int i = input.Length;
            int j = i % 64;
            int zeros;
            int size;
            if (j < 56)
            {
                zeros = 55 - j;
                size = i - j + 64;
            }
            else if (j == 56)
            {
                zeros = 0;
                ones = 0;
                size = i + 8;
            }
            else
            {
                zeros = 63 - j + 56;
                size = i + 64 - j + 64;
            }
            ArrayList bs = new ArrayList(input);
            if (ones == 1)
            {
                bs.Add(128);
            }
            for (int k = 0; k < zeros; k++)
            {
                bs.Add(0);
            }
            ulong N = (ulong)((long)i * 8L);
            byte h = (byte)(N & 255uL);
            byte h2 = (byte)(N >> 8 & 255uL);
            byte h3 = (byte)(N >> 16 & 255uL);
            byte h4 = (byte)(N >> 24 & 255uL);
            byte h5 = (byte)(N >> 32 & 255uL);
            byte h6 = (byte)(N >> 40 & 255uL);
            byte h7 = (byte)(N >> 48 & 255uL);
            byte h8 = (byte)(N >> 56);
            bs.Add(h);
            bs.Add(h2);
            bs.Add(h3);
            bs.Add(h4);
            bs.Add(h5);
            bs.Add(h6);
            bs.Add(h7);
            bs.Add(h8);
            byte[] ts = (byte[])bs.ToArray(typeof(byte));
            uint[] output = new uint[size / 4];
            long l = 0L;
            long m = 0L;
            while (l < (long)size)
            {
                checked
                {
                    output[(int)((IntPtr)m)] = (uint)((int)ts[(int)((IntPtr)l)] | (int)ts[(int)((IntPtr)(unchecked(l + 1L)))] << 8 | (int)ts[(int)((IntPtr)(unchecked(l + 2L)))] << 16 | (int)ts[(int)((IntPtr)(unchecked(l + 3L)))] << 24);
                }
                m += 1L;
                l += 4L;
            }
            return output;
        }

        private static uint[] MD5_Trasform(uint[] x)
        {
            for (int i = 0; i < x.Length; i += 16)
            {
                uint a = Md5Helper.A;
                uint b = Md5Helper.B;
                uint c = Md5Helper.C;
                uint d = Md5Helper.D;
                Md5Helper.FF(ref a, b, c, d, x[i], 7, 3614090360u);
                Md5Helper.FF(ref d, a, b, c, x[i + 1], 12, 3905402710u);
                Md5Helper.FF(ref c, d, a, b, x[i + 2], 17, 606105819u);
                Md5Helper.FF(ref b, c, d, a, x[i + 3], 22, 3250441966u);
                Md5Helper.FF(ref a, b, c, d, x[i + 4], 7, 4118548399u);
                Md5Helper.FF(ref d, a, b, c, x[i + 5], 12, 1200080426u);
                Md5Helper.FF(ref c, d, a, b, x[i + 6], 17, 2821735955u);
                Md5Helper.FF(ref b, c, d, a, x[i + 7], 22, 4249261313u);
                Md5Helper.FF(ref a, b, c, d, x[i + 8], 7, 1770035416u);
                Md5Helper.FF(ref d, a, b, c, x[i + 9], 12, 2336552879u);
                Md5Helper.FF(ref c, d, a, b, x[i + 10], 17, 4294925233u);
                Md5Helper.FF(ref b, c, d, a, x[i + 11], 22, 2304563134u);
                Md5Helper.FF(ref a, b, c, d, x[i + 12], 7, 1804603682u);
                Md5Helper.FF(ref d, a, b, c, x[i + 13], 12, 4254626195u);
                Md5Helper.FF(ref c, d, a, b, x[i + 14], 17, 2792965006u);
                Md5Helper.FF(ref b, c, d, a, x[i + 15], 22, 1236535329u);
                Md5Helper.GG(ref a, b, c, d, x[i + 1], 5, 4129170786u);
                Md5Helper.GG(ref d, a, b, c, x[i + 6], 9, 3225465664u);
                Md5Helper.GG(ref c, d, a, b, x[i + 11], 14, 643717713u);
                Md5Helper.GG(ref b, c, d, a, x[i], 20, 3921069994u);
                Md5Helper.GG(ref a, b, c, d, x[i + 5], 5, 3593408605u);
                Md5Helper.GG(ref d, a, b, c, x[i + 10], 9, 38016083u);
                Md5Helper.GG(ref c, d, a, b, x[i + 15], 14, 3634488961u);
                Md5Helper.GG(ref b, c, d, a, x[i + 4], 20, 3889429448u);
                Md5Helper.GG(ref a, b, c, d, x[i + 9], 5, 568446438u);
                Md5Helper.GG(ref d, a, b, c, x[i + 14], 9, 3275163606u);
                Md5Helper.GG(ref c, d, a, b, x[i + 3], 14, 4107603335u);
                Md5Helper.GG(ref b, c, d, a, x[i + 8], 20, 1163531501u);
                Md5Helper.GG(ref a, b, c, d, x[i + 13], 5, 2850285829u);
                Md5Helper.GG(ref d, a, b, c, x[i + 2], 9, 4243563512u);
                Md5Helper.GG(ref c, d, a, b, x[i + 7], 14, 1735328473u);
                Md5Helper.GG(ref b, c, d, a, x[i + 12], 20, 2368359562u);
                Md5Helper.HH(ref a, b, c, d, x[i + 5], 4, 4294588738u);
                Md5Helper.HH(ref d, a, b, c, x[i + 8], 11, 2272392833u);
                Md5Helper.HH(ref c, d, a, b, x[i + 11], 16, 1839030562u);
                Md5Helper.HH(ref b, c, d, a, x[i + 14], 23, 4259657740u);
                Md5Helper.HH(ref a, b, c, d, x[i + 1], 4, 2763975236u);
                Md5Helper.HH(ref d, a, b, c, x[i + 4], 11, 1272893353u);
                Md5Helper.HH(ref c, d, a, b, x[i + 7], 16, 4139469664u);
                Md5Helper.HH(ref b, c, d, a, x[i + 10], 23, 3200236656u);
                Md5Helper.HH(ref a, b, c, d, x[i + 13], 4, 681279174u);
                Md5Helper.HH(ref d, a, b, c, x[i], 11, 3936430074u);
                Md5Helper.HH(ref c, d, a, b, x[i + 3], 16, 3572445317u);
                Md5Helper.HH(ref b, c, d, a, x[i + 6], 23, 76029189u);
                Md5Helper.HH(ref a, b, c, d, x[i + 9], 4, 3654602809u);
                Md5Helper.HH(ref d, a, b, c, x[i + 12], 11, 3873151461u);
                Md5Helper.HH(ref c, d, a, b, x[i + 15], 16, 530742520u);
                Md5Helper.HH(ref b, c, d, a, x[i + 2], 23, 3299628645u);
                Md5Helper.II(ref a, b, c, d, x[i], 6, 4096336452u);
                Md5Helper.II(ref d, a, b, c, x[i + 7], 10, 1126891415u);
                Md5Helper.II(ref c, d, a, b, x[i + 14], 15, 2878612391u);
                Md5Helper.II(ref b, c, d, a, x[i + 5], 21, 4237533241u);
                Md5Helper.II(ref a, b, c, d, x[i + 12], 6, 1700485571u);
                Md5Helper.II(ref d, a, b, c, x[i + 3], 10, 2399980690u);
                Md5Helper.II(ref c, d, a, b, x[i + 10], 15, 4293915773u);
                Md5Helper.II(ref b, c, d, a, x[i + 1], 21, 2240044497u);
                Md5Helper.II(ref a, b, c, d, x[i + 8], 6, 1873313359u);
                Md5Helper.II(ref d, a, b, c, x[i + 15], 10, 4264355552u);
                Md5Helper.II(ref c, d, a, b, x[i + 6], 15, 2734768916u);
                Md5Helper.II(ref b, c, d, a, x[i + 13], 21, 1309151649u);
                Md5Helper.II(ref a, b, c, d, x[i + 4], 6, 4149444226u);
                Md5Helper.II(ref d, a, b, c, x[i + 11], 10, 3174756917u);
                Md5Helper.II(ref c, d, a, b, x[i + 2], 15, 718787259u);
                Md5Helper.II(ref b, c, d, a, x[i + 9], 21, 3951481745u);
                Md5Helper.A += a;
                Md5Helper.B += b;
                Md5Helper.C += c;
                Md5Helper.D += d;
            }
            return new uint[]
            {
                Md5Helper.A,
                Md5Helper.B,
                Md5Helper.C,
                Md5Helper.D
            };
        }

        public static byte[] MD5Array(byte[] input)
        {
            Md5Helper.MD5_Init();
            uint[] block = Md5Helper.MD5_Append(input);
            uint[] bits = Md5Helper.MD5_Trasform(block);
            byte[] output = new byte[bits.Length * 4];
            int i = 0;
            int j = 0;
            while (i < bits.Length)
            {
                output[j] = (byte)(bits[i] & 255u);
                output[j + 1] = (byte)(bits[i] >> 8 & 255u);
                output[j + 2] = (byte)(bits[i] >> 16 & 255u);
                output[j + 3] = (byte)(bits[i] >> 24 & 255u);
                i++;
                j += 4;
            }
            return output;
        }

        public static string ArrayToHexString(byte[] array, bool uppercase)
        {
            string hexString = "";
            string format = "x2";
            if (uppercase)
            {
                format = "X2";
            }
            for (int i = 0; i < array.Length; i++)
            {
                byte b = array[i];
                hexString += b.ToString(format);
            }
            return hexString;
        }

        public static string MDString(string message)
        {
            char[] c = message.ToCharArray();
            byte[] b = new byte[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                b[i] = (byte)c[i];
            }
            byte[] digest = Md5Helper.MD5Array(b);
            return Md5Helper.ArrayToHexString(digest, false);
        }

        public static string MDFile(string fileName)
        {
            FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read);
            byte[] array = new byte[fs.Length];
            fs.Read(array, 0, (int)fs.Length);
            byte[] digest = Md5Helper.MD5Array(array);
            fs.Close();
            return Md5Helper.ArrayToHexString(digest, false);
        }

        public static string Test(string message)
        {
            return Md5Helper.MDString(message);
        }
    }
}
