using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            if (!int.TryParse(txtN1.Text, out n1) || !int.TryParse(txtN2.Text, out n2))
            {
                lblKqThuTu.Text = "Lỗi: Vui lòng nhập đúng 2 số nguyên!";
                return;
            }

            bool kq = LopTienIch.ThuTu(n1, n2);

            if (kq)
                lblKqThuTu.Text = n1 + " và " + n2 + " là 2 số liên tiếp (True)";
            else
                lblKqThuTu.Text = n1 + " và " + n2 + " KHÔNG phải 2 số liên tiếp (False)";
        }

        private void btnTachChuoi_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string s1 = "", s2 = "";

            LopTienIch.TachChuoi(hoTen, ref s1, ref s2);

            lblKqTachChuoi.Text = "Họ: " + s1 + " | Tên: " + s2;
        }
    }
}
