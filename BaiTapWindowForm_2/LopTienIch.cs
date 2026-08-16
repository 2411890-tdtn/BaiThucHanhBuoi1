using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_2
{
    internal class LopTienIch
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + " " + ten;
        }

        public static long GiaiThua(int n)
        {
            if (n < 0) return 0;

            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua = ketQua * i;
            }
            return ketQua;
        }
    }
}
