using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(string ma, string ten, string nuocSX, double donGia, int soLuong)
        {
            MaThietBi = ma;
            TenThietBi = ten;
            NuocSanXuat = nuocSX;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return "Mã thiết bị: " + MaThietBi + "\r\n" +
                   "Tên thiết bị: " + TenThietBi + "\r\n" +
                   "Nước SX: " + NuocSanXuat + "\r\n" +
                   "Đơn giá: " + DonGia + "\r\n" +
                   "Số lượng: " + SoLuong + "\r\n" +
                   "Thành tiền: " + ThanhTien();
        }
    }
}
