using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string ketQua = "";

            LopTienIch.NoiChuoi(ho, ten, ref ketQua);

            lblKqNoiChuoi.Text = "Họ và tên: " + ketQua;
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (!int.TryParse(txtN.Text, out n) || n < 0)
            {
                lblKqGiaiThua.Text = "Vui lòng nhập số nguyên dương n >= 0!";
                return;
            }

            long kq = LopTienIch.GiaiThua(n);

            lblKqGiaiThua.Text = n + "! = " + kq;
        }
    }
}
