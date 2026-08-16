using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_3
{
    internal class LopTienIch
    {
        public static void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            hoten = hoten.Trim();
            int index = hoten.LastIndexOf(' ');
            if (index > 0)
            {
                s1 = hoten.Substring(0, index); 
                s2 = hoten.Substring(index + 1); 
            }
            else
            {
                s1 = "";
                s2 = hoten;
            }
        }
        public static bool ThuTu(int n1, int n2)
        {
            return n2 == n1 + 1;
        }
    }
}
