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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            bool gioitinh = radNam.Checked; 
            string thongBao = "";

            LopTienIch.ChaoHoi(hoTen, gioitinh, ref thongBao);

            lblKqChao.Text = thongBao;
        }

        private void btnTimUSCLN_Click(object sender, EventArgs e)
        {
            int m = 0, n = 0;

            if (!int.TryParse(txtM.Text, out m) || !int.TryParse(txtN.Text, out n))
            {
                lblKqUSCLN.Text = "Lỗi: Vui lòng nhập đúng 2 số nguyên!";
                return;
            }

            int uscln = LopTienIch.USCLN(m, n);

            lblKqUSCLN.Text = "USCLN của " + m + " và " + n + " là: " + uscln;
        }
    }
}
