using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_4
{
    internal class LopTienIch
    {
        public static void ChaoHoi(string hoten, bool gioitinh, ref string thongBao)
        {
            if (gioitinh)
                thongBao = "Chào Ông " + hoten;
            else
                thongBao = "Chào Bà " + hoten;
        }

        public static int USCLN(int m, int n)
        {
            m = Math.Abs(m);
            n = Math.Abs(n);
            while (n != 0)
            {
                int temp = m % n;
                m = n;
                n = temp;
            }
            return m;
        }
    }
}

