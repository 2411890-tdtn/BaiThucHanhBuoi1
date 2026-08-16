using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_4
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            double lt = 0, th = 0;

            if (!double.TryParse(txtLyThuyet.Text, out lt) || !double.TryParse(txtThucHanh.Text, out th))
            {
                lblKetQua.Text = "Lỗi: Vui lòng nhập đúng định dạng điểm số!";
                return;
            }

            if (lt < 0 || lt > 10 || th < 0 || th > 10)
            {
                lblKetQua.Text = "Lỗi: Điểm số phải nằm trong khoảng từ 0 đến 10!";
                return;
            }

            if (lt < 5 || th < 5)
            {
                lblKetQua.Text = "Yếu";
            }
            else
            {
                double dtb = (lt + th) / 2.0;

                if (dtb < 7)
                    lblKetQua.Text = "Trung bình";
                else if (dtb < 8)
                    lblKetQua.Text = "Khá";
                else if (dtb < 9)
                    lblKetQua.Text = "Giỏi";
                else
                    lblKetQua.Text = "Xuất sắc";
            }
        }
    }
}
