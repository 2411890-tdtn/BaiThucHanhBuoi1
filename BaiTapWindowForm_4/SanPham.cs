using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }

        public SanPham()
        {
            MaSanPham = "SP01";
            TenSanPham = "Bánh Ngọt";
            LoaiSanPham = "Thực phẩm";
            NgaySanXuat = DateTime.Now; 
        }

        public int NamHetHan()
        {
            return NgaySanXuat.Year + 3;
        }

        public string HienThi()
        {
            return "Mã SP: " + MaSanPham + "\r\n" +
                   "Tên SP: " + TenSanPham + "\r\n" +
                   "Loại SP: " + LoaiSanPham + "\r\n" +
                   "Ngày sản xuất: " + NgaySanXuat.ToString("dd/MM/yyyy") + "\r\n" +
                   "Năm hết hạn: " + NamHetHan();
        }
    }
}
