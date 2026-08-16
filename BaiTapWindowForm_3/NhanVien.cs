using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        public NhanVien(string ma, string ten, string ngaySinh, double hsl, double hspc)
        {
            MaNV = ma;
            HoTen = ten;
            NgaySinh = ngaySinh;
            HeSoLuong = hsl;
            HeSoPhuCap = hspc;
        }

        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        public string HienThi()
        {
            return "Mã NV: " + MaNV + "\r\n" +
                   "Họ tên: " + HoTen + "\r\n" +
                   "Ngày sinh: " + NgaySinh + "\r\n" +
                   "Hệ số lương: " + HeSoLuong + "\r\n" +
                   "Hệ số phụ cấp: " + HeSoPhuCap + "\r\n" +
                   "Tổng lương: " + TongLuong().ToString("N0") + " VNĐ";
        }
    }
}
